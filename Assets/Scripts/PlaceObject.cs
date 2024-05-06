using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

[RequireComponent(typeof(ARRaycastManager), typeof(ARPlaneManager))]
public class PlaceObject : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    //[SerializeField]
    //private Button confirmButton;

    //[SerializeField]
    //private TMP_Dropdown dropdown;

    [SerializeField]
    private GameObject confirmButton;

    [SerializeField]
    private GameObject dropdown;

    private ARRaycastManager aRRaycastManager;
    private ARPlaneManager aRPlaneManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private bool PlacedObject = false;

    private void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    public void SetPlaced(bool set)
    {
        PlacedObject = set;
    }

    private void OnEnable()
    {
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown += FingerDown;
    }

    private void onDisable()
    {
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.EnhancedTouchSupport.Disable();
        EnhancedTouch.Touch.onFingerDown -= FingerDown;
    }

    private void FingerDown(EnhancedTouch.Finger finger)
    {
        if (finger.index != 0) return;
        if (PlacedObject) return;

        if (aRRaycastManager.Raycast(finger.currentTouch.screenPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            foreach (ARRaycastHit hit in hits)
            {
                Pose pose = hit.pose;
                GameObject obj = Instantiate(prefab, pose.position, pose.rotation);

                if (aRPlaneManager.GetPlane(hit.trackableId).alignment == PlaneAlignment.HorizontalUp)
                {
                    Vector3 position = obj.transform.position;
                    Vector3 cameraPos = Camera.main.transform.position;

                    Vector3 direction = cameraPos - position;
                    Vector3 targetRotationEuler = Quaternion.LookRotation(direction).eulerAngles;
                    Vector3 scaledEuler = Vector3.Scale(targetRotationEuler, obj.transform.up.normalized);

                    Quaternion targetRotation = Quaternion.Euler(scaledEuler);

                    obj.transform.rotation = obj.transform.rotation * targetRotation;
                    //Enable buttons
                    confirmButton.SetActive(true);
                    dropdown.SetActive(true);
                    confirmButton.GetComponent<ConfirmButton>().UpdateCheck(obj.GetComponent<CheckForObject>());

                    //Stop looking for surfaces
                    PlacedObject = true;

                    //Disable planes
                    aRPlaneManager.SetTrackablesActive(false);
                    aRPlaneManager.enabled = false;

                    GetComponent<ARAnchorManager>().anchorPrefab = obj;
                }
            }

        }
    }
}

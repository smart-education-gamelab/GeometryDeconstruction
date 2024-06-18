using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

[RequireComponent(typeof(ARRaycastManager), typeof(ARPlaneManager))]
public class PlaceARObject : MonoBehaviour
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
    private bool touchSimIsActive = true;

    public GameObject obj;

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
        touchSimIsActive = true;
    }

    private void OnDisable()
    {
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.EnhancedTouchSupport.Disable();
        EnhancedTouch.Touch.onFingerDown -= FingerDown;
        touchSimIsActive = false;
    }

    private void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
            ChangeTouchInputPC();
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
                obj = Instantiate(prefab, pose.position, pose.rotation);

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

    public void DeleteObject()
    {
        Destroy(obj);
    }

    // DEVELOPER INPUT ONLY
    // Enables or disables touch simulation on PC to not conflict with AR simulation
    private void ChangeTouchInputPC()
    {
        if (Input.GetKeyDown(KeyCode.P))
            if (touchSimIsActive)
            {
                EnhancedTouch.TouchSimulation.Disable();
                touchSimIsActive = false;
                Debug.Log("Disable");
            }
            else
            {
                EnhancedTouch.TouchSimulation.Enable();
                touchSimIsActive = true;
                Debug.Log("Enable");
            }
    }
}

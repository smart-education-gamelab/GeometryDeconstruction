using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

//[RequireComponent(typeof(ARRaycastManager))]
public class HighlightObject : MonoBehaviour
{

    //private ARRaycastManager aRRaycastManager;
    //private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    //private Material mat;

    //private void Awake()
    //{
    //    aRRaycastManager = GetComponent<ARRaycastManager>();
    //    mat = GetComponent<Material>();
    //}

    //private void OnEnable()
    //{
    //    EnhancedTouch.TouchSimulation.Enable();
    //    EnhancedTouch.EnhancedTouchSupport.Enable();
    //    EnhancedTouch.Touch.onFingerDown += FingerDown;
    //}

    //private void onDisable()
    //{
    //    EnhancedTouch.TouchSimulation.Disable();
    //    EnhancedTouch.EnhancedTouchSupport.Disable();
    //    EnhancedTouch.Touch.onFingerDown -= FingerDown;
    //}

    //private void FingerDown(EnhancedTouch.Finger finger)
    //{
    //    if (finger.index != 0) return;

    //    Ray ray = GetComponent<Camera>().ScreenPointToRay(finger.currentTouch.screenPosition);
    //    RaycastHit hitObject;
    //    if(Physics.Raycast(ray, out hitObject, 100))
    //    {
    //        Transform selection = hitObject.transform;
    //        ObjectSelect selector = selection.GetComponent<ObjectSelect>();
    //        if (selector != null)
    //        {
    //            selector.ToggleSelection();
    //        }
    //    }

    //    //if (aRRaycastManager.Raycast(finger.currentTouch.screenPosition, hits, TrackableType.AllTypes))
    //    //{
    //    //    foreach (ARRaycastHit hit in hits)
    //    //    {
    //    //    }
    //    //}
    //}
}
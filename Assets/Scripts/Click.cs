using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class Click : MonoBehaviour
{

    public GameObject Model;
    public GameObject placementIndicator;
    public ARRaycastManager arRaycast;
    private Pose placementPose;
    public Camera ARCam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var screenCenter = ARCam.ViewportToScreenPoint( new Vector3( 0.5f, 0.5f ) );
        var hits = new List<ARRaycastHit>();
        arRaycast.Raycast( screenCenter, hits, TrackableType.Planes );
        
        if( hits.Count > 0 ){
            placementPose = hits [0].pose;
            var cameraForward = Camera.main.transform.forward;
            var cameraBearing = new Vector3( cameraForward.x, 0, cameraForward.z ). normalized;
            placementPose.rotation = Quaternion.LookRotation( cameraBearing );
            placementIndicator.SetActive( true );
            placementIndicator.transform.SetPositionAndRotation( placementPose.position, placementPose.rotation );
        }
        else
            placementIndicator.SetActive( false );
    }

    public void ShowModel(){
        Instantiate( Model, placementPose.position, placementPose.rotation );
    }


}

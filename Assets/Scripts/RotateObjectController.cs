using UnityEngine;

public class RotateObjectController : MonoBehaviour
{
    public float PCRotationSpeed = 10f;
    public float MobileRotationSpeed = 0.4f;
    //Drag the camera object here
    public Camera cam;  

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * PCRotationSpeed;
        float rotY = Input.GetAxis("Mouse Y") * PCRotationSpeed;

        Vector3 right = Vector3.Cross(cam.transform.up, transform.position - cam.transform.position);
        Vector3 up = Vector3.Cross(transform.position - cam.transform.position, right);
        transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
        transform.rotation = Quaternion.AngleAxis(rotY, right) * transform.rotation;
        Debug.Log("Rotating objec");
    }

    void Update ()
    {
        // get the user touch input
        foreach (Touch touch in Input.touches) {
            Debug.Log("Touching at: " + touch.position);
            Ray camRay = cam.ScreenPointToRay (touch.position);
            RaycastHit raycastHit;
            if(Physics.Raycast (camRay, out raycastHit, 10))
            {
                if (touch.phase == TouchPhase.Moved) 
                    transform.Rotate (touch.deltaPosition.y * MobileRotationSpeed, 
                        -touch.deltaPosition.x * MobileRotationSpeed, 0, Space.World);
             
            }
        }
    }
}

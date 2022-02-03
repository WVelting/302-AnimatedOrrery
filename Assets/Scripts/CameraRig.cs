using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{   

    public Transform thingToTarget;

    public Transform nextPlanet;
    

    private float pitch = 0;
    private float yaw = 0;
    public float disToTarget = 50;
    private float disToNextPlanet;
    public float mouseSensitivityX = 1;
    public float mouseSensitivityY = 1;
    public float scrollSensitivity = 5;

    private Camera cam;


    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        
    }

    void LateUpdate()
    {
        
        // Update Rotation-----------------
        float lookRight = Input.GetAxisRaw("Mouse X"); //yaw (Y)
        float lookUp = Input.GetAxisRaw("Mouse Y"); //pitch (X)

        yaw += lookRight * mouseSensitivityY;
        pitch -= lookUp * mouseSensitivityX;

        pitch = Mathf.Clamp(pitch, -89, 89);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);

        // Update Zoom------------------------
        Vector2 scrollAmt = Input.mouseScrollDelta;
        disToTarget -= scrollAmt.y * scrollSensitivity;
        
        disToTarget = Mathf.Clamp(disToTarget, 25, 100);

        float z = AniMath.Ease(cam.transform.localPosition.z, -disToTarget, .01f, Time.unscaledDeltaTime);
        
        cam.transform.localPosition = new Vector3(0, 0, z);

        // Update Position--------------------
        if(thingToTarget == null) return;
        //transform.position = thingToTarget.position;

        disToNextPlanet = Mathf.Sqrt(Mathf.Pow((nextPlanet.position.x - transform.position.x), 2) + Mathf.Pow((nextPlanet.position.z - transform.position.z), 2));

        transform.position = AniMath.Ease(transform.position, nextPlanet.position, .01f, Time.unscaledDeltaTime);

        if (disToNextPlanet <= 50){
            thingToTarget = nextPlanet;
            transform.position = AniMath.Ease(transform.position, nextPlanet.position, .000001f, Time.unscaledDeltaTime);
        }

        //if(disToNextPlanet <= 20){
            //transform.position = thingToTarget.position;
        //}
        
    }
}

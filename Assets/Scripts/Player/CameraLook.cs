using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float cameraSensitivity = 3f;

    public Transform cam;

    private Vector3 cameraLook;

    private void Update()
    {
        cameraLook += new Vector3(-Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"), 0) * cameraSensitivity;

        if (cameraLook.x > 90) cameraLook.x = 90;
        else if (cameraLook.x < -90) cameraLook.x = -90;

        transform.eulerAngles = new Vector3(0, cameraLook.y, 0);
        cam.eulerAngles = cameraLook;
    }
}

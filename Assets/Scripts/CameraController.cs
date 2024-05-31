using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 500.0f;
    public float camMin = -45.0f;
    public float camMax = 50.0f;
    private float pitch = 0.0f;
    private float yaw = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            CamOrbit();
        }
    }

    private void CamOrbit()
    {
        // if(Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        // {
        //     float verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        //     float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        //     transform.Rotate(Vector3.right, -verticalInput);
        //     transform.Rotate(Vector3.up, horizontalInput, Space.World);
        // }

        yaw += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        pitch += Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, camMin, camMax);
        transform.eulerAngles = new Vector3(-pitch, yaw, 0.0f);
    }
}

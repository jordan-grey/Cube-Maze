using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRotator : MonoBehaviour
{
    // Update is called once per frame
    public float speedX;
    public float speedY;
    public float speedZ;

    public Transform CamPos;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(transform.position, CamPos.right, speedX * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(transform.position, CamPos.right, -speedX * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, CamPos.up, speedY * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, CamPos.up, -speedY * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(transform.position, CamPos.forward, speedZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(transform.position, CamPos.forward, -speedZ * Time.deltaTime);
        }
    }

    void rotateX(float rotation)
    {
        transform.Rotate(new Vector3 (rotation, 0, 0) * Time.deltaTime);
    }
    void rotateY(float rotation)
    {
        transform.Rotate(new Vector3 (0, rotation, 0) * Time.deltaTime);
    }
    void rotateZ(float rotation)
    {
        transform.Rotate(new Vector3 (0, 0, rotation) * Time.deltaTime);
    }
}

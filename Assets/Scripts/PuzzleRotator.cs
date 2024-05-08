using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRotator : MonoBehaviour
{
    // Update is called once per frame
    public float speedX;
    public float speedY;
    public float speedZ;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rotateX(speedX);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotateX(-speedX);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotateY(speedY);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotateY(-speedY);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotateZ(speedZ);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotateZ(-speedZ);
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

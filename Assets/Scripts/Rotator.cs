using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (0, 0, speed) * Time.deltaTime);
    }
}

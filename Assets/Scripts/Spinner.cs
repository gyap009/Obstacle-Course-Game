using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // float xAngle = 0;
    // [SerializeField] float yAngle = 0.5f;
    // float zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(xAngle, yAngle, zAngle);
        transform.Rotate(0, 0.5f, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 3f;

    public Transform target;

    private Vector2 input;

    // Update is called once per frame
    void Update()
    {
        input += new Vector2(Input.GetAxis("Mouse X") * speed,
            Input.GetAxis("Mouse Y") * speed);
        Quaternion rotation = Quaternion.Euler(input.y, input.x, 0);

        Vector3 position = target.position - (rotation * Vector3.forward * distance);
        transform.localRotation = rotation;
        transform.localPosition = position;
    }
}

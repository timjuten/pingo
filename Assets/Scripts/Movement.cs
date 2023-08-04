using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mainThrust = 1f;
    [SerializeField] float rotationSpeed = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessSideMovement();
    }

    void ProcessThrust() // Processing Thrust on Space
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessSideMovement() // Processing Side Rotation
    {
        if (Input.GetKey(KeyCode.A))
        {
            Rotating(rotationSpeed);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Rotating(-rotationSpeed);
        }
    }

    void Rotating(float speed) // Rotating function
    {
        rb.freezeRotation = true; // Freezing rotation so we can manually rotate
        transform.Rotate(speed * Vector3.forward * Time.deltaTime);
        rb.freezeRotation = false;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetProperties(1f);
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(Vector3.up * speed);
    }

    void SetProperties(float speed)
    {
        this.speed = speed;
    }
}

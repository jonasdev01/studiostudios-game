using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeController : MonoBehaviour
{
    public float speed = 0.3f;

    // Update is called once per frame
    void Update()
    {
        float deltaVertical = 0f;
        float deltaHorizontal = 0f;

        if (Input.GetKey(KeyCode.W))
            deltaVertical = 1.0f;
        else if (Input.GetKey(KeyCode.S))
            deltaVertical = -1.0f;

        if (Input.GetKey(KeyCode.D))
            deltaHorizontal = 1.0f;
        else if (Input.GetKey(KeyCode.A))
            deltaHorizontal = -1.0f;

        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x + deltaHorizontal * speed, pos.y, pos.z + deltaVertical * speed);
    }
}

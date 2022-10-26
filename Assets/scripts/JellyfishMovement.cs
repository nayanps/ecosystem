using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyfishMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.y += speed * Time.deltaTime;

        if (pos.y > 6)
        {
            pos.y = -6f;
            pos.x += 1f;
        }

        if (pos.x > 9)
        {
            pos.x = -9f;
        }

        transform.position = pos;

    }
}

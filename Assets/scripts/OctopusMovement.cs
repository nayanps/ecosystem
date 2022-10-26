using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        Vector3 pos = transform.position;

        pos.y += speed * Time.deltaTime;
        pos.x += speed * Time.deltaTime;

        if (pos.y > 6)
        {
            pos.y = -6f;
            pos.x += Random.Range(-9.0f, 9.0f);
        }

        if (pos.x > 9)
        {
            pos.x = Random.Range(-9.0f, 9.0f);
        }

        transform.position = pos;

    }
}

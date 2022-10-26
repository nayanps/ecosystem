using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= speed * Time.deltaTime;

        if (pos.x < -9)
        {
            pos.y += Random.Range(-6.0f, 6.0f);
            pos.x = 9;
        }

        transform.position = pos;

    }
}

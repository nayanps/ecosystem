using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OTEDestroyObject : MonoBehaviour
{
    public string animal_type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == animal_type)
        {
            Destroy(gameObject);
        }
    }
}

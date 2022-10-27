using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class FishMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public string animal_type;
    public AudioSource star_noise;

    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= speed * Time.deltaTime;

        if (pos.x < -9)
        {
            pos.y += Random.Range(-6.0f, 6.0f);
            pos.x = 9;
        }

        if (pos.x > 9)
        {
            pos.y += Random.Range(-6.0f, 6.0f);
            pos.x = -9;
        }

        transform.position = pos;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 pos = transform.position;
        transform.position = pos;

        if (other.gameObject.CompareTag(animal_type))
        {
            star_noise.Play();  
            speed = -speed;
        }
    }
}

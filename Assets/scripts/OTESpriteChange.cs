using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OTESpriteChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite triggered_sprite;
    public string animal_type;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == animal_type)
        {
            spriteRenderer.sprite = triggered_sprite;
        }
    }
}

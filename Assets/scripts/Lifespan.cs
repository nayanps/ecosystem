using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifespan : MonoBehaviour
{
    public int length;
    private IEnumerator Life()
    {
        float rotation = transform.rotation.y;
        while (true)
        {
            yield return new WaitForSeconds(length);
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        StartCoroutine(Life());
    }
}

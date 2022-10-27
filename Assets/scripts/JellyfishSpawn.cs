using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyfishSpawn : MonoBehaviour
{
    public GameObject jellyfish;
    void Start()
    {
        StartCoroutine(CreateJellyfish());

    }

    IEnumerator CreateJellyfish()
    {
        while (true)
        {
            var jellyfish_range = new Vector3(Random.Range(-9.0f, 9.0f), 6.0f, 0);
            Instantiate(jellyfish, jellyfish_range, Quaternion.identity);
            yield return new WaitForSeconds(15f);
        }
    }
}

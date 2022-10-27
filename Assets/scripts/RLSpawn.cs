using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLSpawn : MonoBehaviour
{
    public GameObject spawn;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    { //generates its every 0.25s
        while (true)
        {
            var spawn_range = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-6.0f, 6.0f), 0);
            Instantiate(spawn, spawn_range, Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}

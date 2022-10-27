using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishSpawn : MonoBehaviour
{
    public GameObject fish;
    public AudioSource bubble;

  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateFish());
        
    }

    IEnumerator CreateFish()
    { //generates its every 0.25s
        while (true)
        {
            var fish_range = new Vector3(9.0f, Random.Range(-6.0f, 6.0f), 0);
            Instantiate(fish, fish_range, Quaternion.identity);
            bubble.Play();
            yield return new WaitForSeconds(10f);
        }
    }
}

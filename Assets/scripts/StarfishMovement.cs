using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarfishMovement : MonoBehaviour
{
    private IEnumerator Rotate()
    {
        float rotation = transform.rotation.y;
        while (true)
        {
            rotation += 10;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotation)); // rotate on y axis
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void Start()
    {
        StartCoroutine(Rotate());
    }
}

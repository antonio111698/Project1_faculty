using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;



public class rock : MonoBehaviour
{
    bool wait = false;
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        wait = true;
        gameObject.SetActive(true);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        transform.position = new Vector3(Random.Range(-11, 18), Random.Range(-8, 8), 0);
        wait = false;
    }
    void Update()
    {
        if (!wait)
        {
            StartCoroutine(ExampleCoroutine());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacol"))
        {
            transform.position = new Vector3(Random.Range(-11, 18), Random.Range(-8, 8), 0);
        }
    }
}
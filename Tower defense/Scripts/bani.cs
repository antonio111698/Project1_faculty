using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bani : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacol"))
        {
            transform.position = new Vector3(Random.Range(-11, 18), Random.Range(-8, 8), 0);
        }
	}
}

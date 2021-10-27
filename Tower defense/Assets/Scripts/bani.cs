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
        if (collision.gameObject.CompareTag("ban"))
        {
            transform.position = new Vector3(Random.Range(-11, 18), Random.Range(-8, 8), 0);
        }
	}
	void OnTriggerEnter2D(Collider2D col)
	{
        if (col.gameObject.CompareTag("Player"))
        {
            Score.Coin += 1;
            transform.position = new Vector3(Random.Range(-11, 18), Random.Range(-8, 8), 0);

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,5f)]
    [SerializeField] float walkSpeed = 1f;
    public HealthManager healthMan;

    // Start is called before the first frame update
    void Start()
    {
        healthMan = (HealthManager)FindObjectOfType(typeof(HealthManager));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("death"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("playerDeath"))
        {
            healthMan.LoseLives();
            gameObject.SetActive(false);
        
        }
       
    }

}

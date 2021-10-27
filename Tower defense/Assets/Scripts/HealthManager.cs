using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth;

    private bool flashActive;
    [SerializeField]
    private float flashLength = 0f;
    private float flashCounter = 0f;
    private SpriteRenderer playerSprite;
    public int lives = 3;

    [SerializeField] private GameObject gameOverUI;
    


    // Start is called before the first frame update
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(flashActive)
        {
            if(flashCounter>flashLength*.99f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);

            }
            else if(flashCounter>flashLength*.82f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if(flashCounter>flashLength*.66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);

            }
            else if(flashCounter>flashLength*.49f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);

            }
            else if(flashCounter>flashLength*.33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if(flashCounter>flashLength*.16f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if(flashCounter>0f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else         
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }
   public void HurtPlayer(int damageToGive)
    {
        currentHealth -= damageToGive;
        flashActive = true;
        flashCounter = flashLength;
        if(currentHealth<=0)
        {
            //gameObject.SetActive(false);
            LoseLives();
            currentHealth = 60;

        }
    }
    public void LoseLives()
    {
        lives--;
        print(lives);
        if (lives <= 0)
        {
            gameObject.SetActive(false);
            print("game over");
            gameOverUI.SetActive(true);
            


        }
        
        
    }

}

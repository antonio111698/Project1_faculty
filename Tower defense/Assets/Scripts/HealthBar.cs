using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    private HealthManager healthMan;
    public Slider healthbar;
    public Text hpText;
    // Start is called before the first frame update
    void Start()
    {
        healthMan = FindObjectOfType<HealthManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.maxValue = healthMan.maxHealth;
        healthbar.value = healthMan.currentHealth;
        hpText.text = "HP: " + healthMan.currentHealth + "/" + healthMan.maxHealth;
    }
}

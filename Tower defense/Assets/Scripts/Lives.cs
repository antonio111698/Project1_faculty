using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
	Text text;
	public HealthManager healthMan;
    // Start is called before the first frame update
    void Start()
    {
         text = GetComponent<Text> ();
		 healthMan = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = healthMan.lives.ToString();
		
    }
}

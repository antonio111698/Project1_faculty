using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject[] spawners;
    void Start()
    {
        //Dezactivati ce altceva nu tre sa miste inainte de start aici.. 
        GameObject.FindObjectOfType<PlayerMovement>().enabled = false;
        
    }

    public void StartButtonPressed()
    {
        //Reactivati-le aici
        menu.gameObject.SetActive(false);
        GameObject.FindObjectOfType<PlayerMovement>().enabled = true;
        foreach (GameObject obj in spawners)
        {
            obj.SetActive(true);
        }
    }

    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}

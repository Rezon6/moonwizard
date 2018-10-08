using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //skripta fyrir UI: líf
    int health = 3;
    public Text healthText;
   
    void Update()
    {
        health = PlayerHealth.currentHealth;
        healthText.text = "HEALTH : " + health;
    }
}

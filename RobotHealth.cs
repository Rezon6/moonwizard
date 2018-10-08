using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHealth : MonoBehaviour {
    //skripta til að tracka líf robotana
    public int health;
    private int currentHealth;
    public static int killCount = 0;


	void Start ()
    {
        currentHealth = health;
	}
	
	void Update ()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            killCount++;
        }
	}


    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}

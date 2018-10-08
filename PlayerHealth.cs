using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    //skripta til að tracka líf spilarans
    //var að skoða mismunandi leiðir til að láta hann blikka til að sýna viðbrögð en þurfti að sleppa því í bili og commentaði það út

    //public Material[] Materials;
    public int startingHealth;
    public static int currentHealth = 1;
    public static bool gameOver;

    //public float feedbackLength;
    //private float feedbackCounter;

    //public Renderer rend;
    //private Color storedColor;//
	void Start ()
    {
        currentHealth = startingHealth;
        //rend = GetComponent<Renderer>();
        //storedColor = rend.material.GetColor("_Color");


	}
	
	
	void Update ()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
            gameOver = true;
            
        }

        // if (feedbackCounter > 0)
        // {
          //  feedbackCounter -= Time.deltaTime;
           // if (feedbackCounter <= 0)
          //  {
                //rend.material.SetColor("_Color", storedColor);
          //  }
       // }
	}

    public void HurtPlayer(int damageAmount)
    {
        //feedbackCounter = feedbackLength;
        currentHealth -= damageAmount;
       // Material[] mats = rend.materials;
       // mats[0] = Materials[0];
       // rend.materials = mats;
    }
}

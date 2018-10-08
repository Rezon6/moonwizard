using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour {

    //skripta sem sér um að skjóta

    public bool isFiring;
    public MagicProjectile MagicMissle;
    public float missleSpeed;
    public float delay;
    private float counter;

    public Transform Wand;

	void Start () {
		
	}
	

	void Update () {
        if (isFiring)
        {
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                counter = delay;
                MagicProjectile newMagicMissle = Instantiate(MagicMissle, Wand.position, Wand.rotation);
                newMagicMissle.speed = missleSpeed;
            }
        }

        else
        {
            counter = 0;
        }
	}
}

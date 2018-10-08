using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    //skripta sem sér um óvinina

    Animator anim;
    private Rigidbody myRB;
    public float speed;

    public PlayerMovement thePlayer;

	
	void Start ()
    {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerMovement>();
        anim = GetComponent<Animator>();

    }
    private void FixedUpdate()
    {
        myRB.velocity = (transform.forward * speed);
        anim.Play("Run");
        
    }

    void Update ()
    {

        transform.LookAt(thePlayer.transform.position);
		
	}
}

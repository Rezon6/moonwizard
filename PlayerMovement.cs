using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Animator anim;
    public float moveSpeed;
    public Rigidbody rb;
    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public WandController theWand;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


    void Update() {
        //hreyfing spilara
        moveInput = new Vector3(Input.GetAxisRaw("LeftJoystickHorizontal"), 0f, Input.GetAxisRaw("LeftJoystickVertical"));
        moveVelocity = moveInput * moveSpeed;
        if (moveVelocity.sqrMagnitude > 0.2)
        {
            anim.Play("Run");
        }

        //snúningur spilara
        Vector3 moveRotationRight = Vector3.right * -Input.GetAxisRaw("RightJoystickHorizontal") + Vector3.forward * Input.GetAxisRaw("RightJoystickVertical");
        Vector3 moveRotationLeft = Vector3.right * Input.GetAxisRaw("LeftJoystickHorizontal") + Vector3.forward * Input.GetAxisRaw("LeftJoystickVertical");

        //checkar hvort hann ætti að nota hægri eða vinstri stickið til að snúa spilaranum

            
            if (moveRotationRight.sqrMagnitude > 0.0f)
            {
                Quaternion rotation = Quaternion.LookRotation(moveRotationRight, Vector3.up);
                transform.rotation = rotation;
            }
   

        else
        {
            
            if (moveRotationLeft.sqrMagnitude > 0.0f)
            {
                Quaternion rotation = Quaternion.LookRotation(moveRotationLeft, Vector3.up);
                transform.rotation = rotation;
            }

        }
            //skýtur ef spilari ýtir á R1
        if (Input.GetButton("R1"))
        {
            theWand.isFiring = true;
        }

        else
        {
            theWand.isFiring = false;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}

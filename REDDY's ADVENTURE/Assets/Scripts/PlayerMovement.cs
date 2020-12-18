using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    public Animator animator;
    public Rigidbody2D rb;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
       
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButton("Jump")) {

            jump = true; // when press button jump will be enable
            animator.SetBool("IsJumping",true);
        
        }
    }

    public void OnLanding() {

        animator.SetBool("IsJumping",false);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        jump = false;

        if (rb.position.y < -4) {

            FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<PlayerMovement>().enabled = false;
        }
    }
}

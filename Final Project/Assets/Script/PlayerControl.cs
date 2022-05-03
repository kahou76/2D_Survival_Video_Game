using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    // private bool isMoving;
    private Vector2 input;
    // private Vector2 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            
        ProcessInputs();
        
    }



    void FixedUpdate() {
        //physics calculations
        Move();
    }

    void ProcessInputs(){
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        //moveDirection = new Vector2(moveX,moveY);
    }


    void Move(){
       // rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
       rb.velocity = input.normalized * moveSpeed;

       CheckForFlipping();
    }

    void CheckForFlipping(){
        bool movingLeft = input.x < 0;
        bool movingRight = input.x > 0;
        
        if(movingLeft){
            transform.localScale = new Vector3(-1f,transform.localScale.y);
        }

        if(movingRight){
            transform.localScale = new Vector3(1f,transform.localScale.y);
        }
    }
    
    
}

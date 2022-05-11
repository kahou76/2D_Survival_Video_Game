using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWASD : MonoBehaviour
{
    public float speed = 3f;

    public Rigidbody2D rb;
    public Vector2 pos;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 

        pos = transform.position;
 
        if (Input.GetKey ("w")) {
            pos.y += speed * Time.deltaTime;
            //animator.SetFloat("speed",Mathf.Abs(speed));
        }
        if (Input.GetKey ("s")) {
            pos.y -= speed * Time.deltaTime;
            //animator.SetFloat("speed",Mathf.Abs(speed));
        }
        if (Input.GetKey ("d")) {
            pos.x += speed * Time.deltaTime;
            transform.localScale = new Vector3(1f,transform.localScale.y);
            animator.SetFloat("speed",Mathf.Abs(speed));
        }
        if (Input.GetKey ("a")) {
            pos.x -= speed * Time.deltaTime;
            transform.localScale = new Vector3(-1f,transform.localScale.y);
            animator.SetFloat("speed",Mathf.Abs(speed));
        }

        
            

        transform.position = pos;

        //CheckForFlipping();
        
    }

    void CheckForFlipping(){
        bool movingLeft =  pos.x < 0;
        bool movingRight = pos.x > 0;

        if(movingLeft){
            transform.localScale = new Vector3(-1f,transform.localScale.y);
        }

        if(movingRight){
            transform.localScale = new Vector3(1f,transform.localScale.y);
        }
    }
}

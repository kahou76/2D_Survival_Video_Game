using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementArrow : MonoBehaviour
{
    public float speed = 3f;

    public Rigidbody2D rb;
    public Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 

        pos = transform.position;
 
        if (Input.GetKey ("u")) {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey ("j")) {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey ("k")) {
            pos.x += speed * Time.deltaTime;
            transform.localScale = new Vector3(1f,transform.localScale.y);
        }
        if (Input.GetKey ("h")) {
            pos.x -= speed * Time.deltaTime;
            transform.localScale = new Vector3(-1f,transform.localScale.y);
        }
            

        transform.position = pos;

        // CheckForFlipping();
        
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

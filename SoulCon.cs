using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCon : MonoBehaviour
{
    //creates velosity speed and rigidbody variables. 
    private Vector2 Vel;
    public float speed;
    private Rigidbody2D rb;
    // Update is called once per frame

    void Start()
    {
        //attaches rigidbody to the variable called rb. 
        rb = GetComponent<Rigidbody2D>();


    }
    void Update()
    {
        //takes input from the player.  
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //uses input from player and speed to set vel(velosity). 
        Vel = input.normalized * speed;

    }

    void FixedUpdate()
    {
        //moves the player based on imput. 
        rb.MovePosition(rb.position + Vel * Time.fixedDeltaTime);
    }
}

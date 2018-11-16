using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCon : MonoBehaviour
{

    private Vector2 Vel;
    public float speed;
    private Rigidbody2D rb;
    // Update is called once per frame

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vel = input.normalized * speed;

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vel * Time.fixedDeltaTime);
    }
}

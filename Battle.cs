using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Battle : MonoBehaviour
{
    public float Speed;
    public Transform target;
    private float timer;
    private float turntimer = 10;
    public static bool NextTurn = false; 
    private bool isMoveing;
    public float moveDuration = 3f;
    public float stayDuration = 2f;
    
    // Use this for initialization
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        timer = 0; 
    }

    // Update is called once per frame
    void Update()
    {

        MoveToPlayer();
        UpdateTimer(); 
    }

    void MoveToPlayer()
    {
        if (isMoveing == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }
        else if (turntimer >= 10)
        {
            NextTurn = true; 
        }

    }
    void UpdateTimer()
    {
        timer += Time.deltaTime;
        turntimer += Time.deltaTime; 
        if (isMoveing == true)
        {
            if (timer > moveDuration)
            {
                timer = 0; 
                isMoveing = false;
            }
        }

        if (isMoveing == false)
        {
            if (timer > stayDuration)
            {
                timer = 0; 
                isMoveing = true;
            }
            
            
        } 
    }
}
        
   // }




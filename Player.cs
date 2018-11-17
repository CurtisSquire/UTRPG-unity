using UnityEngine;


public class Player : MonoBehaviour {
    //creates variables 
    private float timer;
    private bool isInvinsible;
    public float TimerForInvincibility = 3f;
    void Start()
    {
        //starts timer at 0
        timer = 0;     
    }

    void Update()
    {
        //calls update invincibility method. 
        UpdateInvincibility();
        
    }
    //creates update invincibility method. 
    void UpdateInvincibility()
    {
        //if player is invinsible they will not take damage. a timer will start for when they can take damage again. 
        if (isInvinsible == true)
        {
            timer += Time.deltaTime;
            if (timer > TimerForInvincibility)
            {
                //sets invincibility to false after timer runs out. 
                timer = 0;
                isInvinsible = false;
            }
        }
        
    }
    // when collition is detected player will lose health unless isInvinsible is true. 
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Enemy"))
        {
            if (isInvinsible == false && Health.life > 0)
            {
                Destroy(c.gameObject);
                Health.life -= 1;
                isInvinsible = true; 
                Debug.Log(Health.life);
                Debug.Log(c.gameObject.name); 
            }
        }
    }
}


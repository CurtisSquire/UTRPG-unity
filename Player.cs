using UnityEngine;


public class Player : MonoBehaviour {
    private float timer;
    private bool isInvinsible;
    public float TimerForInvincibility = 3f;
    void Start()
    {
        timer = 0;     
    }

    void Update()
    {
        UpdateInvincibility();
        
    }

    void UpdateInvincibility()
    {
        
        if (isInvinsible == true)
        {
            timer += Time.deltaTime;
            if (timer > TimerForInvincibility)
            {
                timer = 0;
                isInvinsible = false;
            }
        }
        
    }

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


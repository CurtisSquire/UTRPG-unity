using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject heart;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;

    public static int life;

    void Start()
    {
        life = 5;
        heart.gameObject.SetActive(true);
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true); 
    }

    void Update()
    {
        if (life > 5)
            life = 5; 

        switch (life)
        {
            case 5:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                break;
            case 4:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                break;
            case 3:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 2:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 1:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 0:
                heart.gameObject.SetActive(false);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                Time.timeScale = 0;
                SceneManager.LoadScene("GameOverScene");
                break; 
        }
    }
}
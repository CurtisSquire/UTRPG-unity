using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TurnState : MonoBehaviour {
    public GameObject UIBattleMenu; 
    private Turns whosTurn;
    public static float BattleTurn;
    public float EnemyTurnTimer = 0;
    private float EnemyTurnDuration = 10.0f;
    public float EnemyHealth = 2;
	public enum Turns
       
    { 
        PLAYERTURN, 
        ENEMYTURN, 
        LOSE, 
        WIN 
    }

    void Start()
    {
        whosTurn = Turns.PLAYERTURN; 
    }

    void Update()
    {
        
       switch(whosTurn)
        {
            case (Turns.PLAYERTURN):
                UIBattleMenu.SetActive(true);
                Time.timeScale = 0.0f;
                break;
            case (Turns.ENEMYTURN):
                UpdateEnemyTurnTimer();
                UIBattleMenu.SetActive(false); 
                break;
            case (Turns.LOSE):
                break;
            case (Turns.WIN):
                break; 
        }
        if (EnemyHealth <= 0)
        {
            SceneManager.LoadScene("WIN"); 
        }
    }
    void UpdateEnemyTurnTimer()
    {
        EnemyTurnTimer += Time.deltaTime; 
        if (EnemyTurnTimer >= EnemyTurnDuration)
        {
           
            EnemyTurnTimer = 0;
            whosTurn = Turns.PLAYERTURN;
            Debug.Log("PlayerTurn!!!!"); 
        }
        
    }
    public void PlayerAttack()
    {
        Debug.Log("ATTACK!!!"); 

        if (whosTurn == Turns.PLAYERTURN)
        {
            EnemyHealth -= 1; 
            Debug.Log("EnemyTurn!!!");
            whosTurn = Turns.ENEMYTURN;
        }
    }
   
    //void ChangeState() 
    //{
        //if (attack button is pressed)
//        {
//
//        }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//i make sure to include scene management in this one so that I can use the win and lose scene screens. 
using UnityEngine.SceneManagement; 

public class TurnState : MonoBehaviour {
    //creats variables
    public GameObject UIBattleMenu; 
    private Turns whosTurn;
    public static float BattleTurn;
    public float EnemyTurnTimer = 0;
    private float EnemyTurnDuration = 10.0f;
    private GameObject[] AttackOne; 
    private float EnemyHealth = 5.0f;
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
                //when on the players turn the menu is set active so the player can chose their next option. 
                //timescale is set to zero so that the enemy can't attack the player during the players turn. 
                UIBattleMenu.SetActive(true);
                Time.timeScale = 0.0f;
             
                break;
            case (Turns.ENEMYTURN):
                //calls the UpdateEnemyTurnTimer method that I created below. 
                UpdateEnemyTurnTimer();
                //sets the menu so that it is not active and will not be on screen during the enemys turn. 
                UIBattleMenu.SetActive(false);
                //sets timescale back to normal so that the enemy can attack again. 
                Time.timeScale = 1.0f;
                break;
            case (Turns.LOSE):
                break;
            case (Turns.WIN):
                break; 
        }
        //displayes the win screen scene if enemy is killed. 
        if (EnemyHealth <= 0)
        {
            SceneManager.LoadScene("WIN"); 
        }
    }
    //creates turntimer method. 
    void UpdateEnemyTurnTimer()
    {
        //starts ticking the timer to move up by one per second. 
        EnemyTurnTimer += Time.deltaTime;
        //if the enemy timer is greater than there turn is supposed to be reset the timer and go to the players turn. 
        if (EnemyTurnTimer >= EnemyTurnDuration)
        {
           
            EnemyTurnTimer = 0;
            whosTurn = Turns.PLAYERTURN;
            Debug.Log("PlayerTurn!!!!"); 
        }
        
    }
    //creates player attack method. 
    public void PlayerAttack()
    {
        Debug.Log("ATTACK!!!"); 

        if (whosTurn == Turns.PLAYERTURN)
        {
            //if player attacks during their turn enemy health is taken down by one. 
            EnemyHealth -= 1; 
            Debug.Log("EnemyTurn!!!");
            //sets it back to enemys turn after player attacks. 
            whosTurn = Turns.ENEMYTURN;
        }
    }
    //creates playerpass method. 
    public void PlayerPass()
    {
        //if player passes their turn it simply goes to the enemys turn. 
        whosTurn = Turns.ENEMYTURN; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Battle System!!");

        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10

        float playerOneStyle = Random.Range(1, 10);

        // luck should be random between 0-4

        float playerOneLuck = Random.Range(0, 4);

        // ryhtm should be random between 1-6

        float playerOneRyhtm = Random.Range(1, 6);

        // style should be random between 1-10

        float playerTwoStyle = Random.Range(1, 10);

        // luck should be random between 0-4

        float playerTwoLuck = Random.Range(0, 4);

        // ryhtm should be random between 1-6

        float playerTwoRyhtm = Random.Range(1, 6);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.

        float playerOnePowerLevel = (playerOneLuck + playerOneStyle + playerOneRyhtm);
        float playerTwoPowerLevel = (playerTwoLuck + playerTwoStyle + playerTwoRyhtm);

        // Debug out the two players, power levels.

        Debug.Log("Player One: " + playerOnePowerLevel + "Power!");

        Debug.Log("Player Two: " + playerTwoPowerLevel + "Power!");

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.

        float totalPower = (playerOnePowerLevel + playerTwoPowerLevel);

        float playerOneChanceToWin = (playerOnePowerLevel / totalPower * 100);

        float playerTwoChanceToWin = (playerTwoPowerLevel / totalPower * 100);

        // Debug out the chance of each character to win.

        Debug.Log("Player One chances: " + playerOneChanceToWin + "%");

        Debug.Log("Player Two chances: " + playerTwoChanceToWin + "%");

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  

        if (playerOneChanceToWin > playerTwoChanceToWin)
        {
            // Debug out which character has won, which has lost, or if it's a draw. 
            // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.

            Debug.Log("Player One wins.");

            Debug.Log("Player One XP: +" + (20 + (((playerOneChanceToWin - playerTwoChanceToWin) * 100) / 100)));

            Debug.Log("Player Two XP: +" + 20);


        }

        else if (playerOneChanceToWin < playerTwoChanceToWin)
        {
            Debug.Log("Player Two wins.");

            Debug.Log("Player One XP: +" + 20);

            Debug.Log("Player Two XP: +" + (20 + (((playerTwoChanceToWin - playerOneChanceToWin) * 100) / 100)));
        }

        else
        {

            Debug.Log("DRAW!");

        }
    }
}

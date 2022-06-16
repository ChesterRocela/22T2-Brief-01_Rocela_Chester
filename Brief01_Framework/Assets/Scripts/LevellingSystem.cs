using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int curretLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    private void Start()
    {
        Debug.Log("LEVELLING SYSTEM: ");

        // set our current level to one.

        int currentLevel = 1;

        // set our current XP to zero

        int currentXp = 0;

        // set our current XP Threshold to be our level multiplied by our 100.

        int currentXPThreshold = currentLevel * 100;

        // Debug out our starting values of our level, xp and current xp threshold

        Debug.Log("Level: " + currentLevel);

        Debug.Log("XP: " + currentXp);

        Debug.Log("XP needed for Level Up: " + currentXPThreshold);


        // Increase the current XP by one hundred.

        int newXp = currentXp + 120;
        {
            Debug.Log("XP Gained: " + newXp);

            // Debug out our current XP.

            Debug.Log("XP: " + newXp);
        }

        // check if our current XP is more than our threshold.

        if (newXp > 100)
        {
            Debug.Log("You have levelled up!");

            // if it is, then let's increase out level by one.

            int newLevel = currentLevel + 1;

            // let's also increase recalculate our current xp threshold as we've levelled up.

            int newXPThreshold = newLevel * 100;

            // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.
            Debug.Log("Level: " + newLevel);

            Debug.Log("XP: " + (newXp - currentXPThreshold));

            Debug.Log("XP needed for Level Up: " + newXPThreshold);
        }
        else
        {
            Debug.Log("Gain more XP to level up.");
        }
}

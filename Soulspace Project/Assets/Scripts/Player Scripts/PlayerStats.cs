using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Player state
    private bool playerAlive = true;

    //Health Variables
    public int healthStat = 10; // Determines maximum health that can be carried
    private float healthCount = 10.0f; // How much health the player currently has

    //Stamina Variables
    public int staminaStat = 10; // Determines maximum stamina that can be carried
    private float staminaCount = 0f; // How much stamina the player currently has
    private float staminaRegenTimer = 0.0f; // Timer variable between stamina recharge

    // Start is called before the first frame update
    void Start()
    {
        //Player starts off with maximum health and stamina
        healthCount = healthStat;
        staminaCount = staminaStat;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is alive
        if (healthCount <= 0)
        {playerAlive = false;}
        
        // Stamina Regen System
        else if (staminaCount < staminaStat && staminaRegenTimer <=0)
        {staminaCount += 1 * Time.deltaTime;}
        //Debug.Log("Stamina: " + staminaCount);
    }
}

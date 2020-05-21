using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// More information on Basic Movement code: https://www.youtube.com/watch?v=LNLVOjbrQj4
// More information on Dash Skill Code: https://www.youtube.com/watch?v=w4YV8s9Wi3w
public class PlayerMovement : MonoBehaviour
{
    //we will stop player from moving if the dialogue is open.
    DialogueManager dialogueManager;
    //ESSENTIAL: Basic Movement
    //moveSpeed - Determines the speed of movement for player character
    public float moveSpeed = 3f;

    //ESSENTIAL: Basic Movement + Dash Skill
    //rb - Rigidbody Component Variable
    public Rigidbody2D rb;

    //ESSENTIAL: Basic Movement
    //movement - XY Variable
    Vector2 movement;

    //ESSENTIAL: Dash Skill
    //Intended to tweak the "Speed" of the character when activated
    public float dashSpeed;

    //ESSENTIAL: Dash Skill
    //Determines how long the dash skill lasts
    private float dashTime;

    //ESSENTIAL: Dash Skill
    //Used to decrease the value of "dashTime" in game. When dashTime reaches 0, it can reset using "startDashTime"
    public float startDashTime;

    private void Awake()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    //ESSENTIAL: Basic Movement
    // Update is called once per frame
    void Update()
    {
        //ESSENTIAL: Basic Movement
        //Gets movement of XY factors
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (!dialogueManager.dialogueOn)
        {
            //ESSENTIAL: Basic Movement
            //This code uses all Variables in this script to move player
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            //Delta time will make it rely on time and not how often Fixed Update has been called
        }
    }
}

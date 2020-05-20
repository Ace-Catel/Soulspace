using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// More info about Dialogue Text from this video: https://www.youtube.com/watch?v=_nRzoTzeyxU
[RequireComponent(typeof(CircleCollider2D))]
public class DialogueTrigger : MonoBehaviour
{
    public bool playerOn = false;
    public Dialogue dialogue;
    DialogueManager dialogueManager;
    Collider2D rangeCollider;

    private void Start()
    {
        dialogueManager = GameObject.FindObjectOfType<DialogueManager>();
        rangeCollider = GetComponent<Collider2D>();        
    }

    private void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.E)) && playerOn && !dialogueManager.dialogueOn)
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue ()
    {
        //start the dialogue
        dialogueManager.StartDialogue(dialogue);
        //set this gameobject as the dialogue trigger to the dialogue manager
        dialogueManager.dialogueTrigger = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            playerOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag.Equals("Player"))
        {
            playerOn = false;
        }
    }

}

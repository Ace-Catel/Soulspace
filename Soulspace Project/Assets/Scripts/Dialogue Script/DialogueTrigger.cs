using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// More info about Dialogue Text from this video: https://www.youtube.com/watch?v=_nRzoTzeyxU

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void triggerDialogue ()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}

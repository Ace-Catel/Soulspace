using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePanelAnimator : MonoBehaviour
{
    Animator dialogueAnim;
    bool displayDialogue;
    public bool DisplayDialogue
    {
        get
        {
            return displayDialogue;
        }
        set
        {
            displayDialogue = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        dialogueAnim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        dialogueAnim.SetBool("DisplayDialogue", displayDialogue);
    }
}

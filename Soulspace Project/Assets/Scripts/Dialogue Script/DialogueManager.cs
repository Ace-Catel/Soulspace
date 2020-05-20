using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// More info about Dialogue Text from this video: https://www.youtube.com/watch?v=_nRzoTzeyxU
public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public bool dialogueOn;

    [HideInInspector]
    public DialogueTrigger dialogueTrigger;
    DialoguePanelAnimator dialoguePanel;
    Queue<string> sentences;
    

    // Start is called before the first frame update
    void Start()
    {
        //this will only work if there is only DialoguePanelAnimator script on the scene
        dialoguePanel = GameObject.FindObjectOfType<DialoguePanelAnimator>();
        dialogueTrigger = null;
        dialogueOn = false;
        sentences = new Queue<string>();
    }

    private void Update()
    {
        dialoguePanel.DisplayDialogue = dialogueOn;
        if (dialogueTrigger)
        {
            if (dialogueTrigger.playerOn && Input.GetKeyDown(KeyCode.E))
            {
                DisplayNextSentence();
            }
        }
    }

    public void StartDialogue (Dialogue dialogue)
    {
        dialogueOn = true;
        nameText.text = dialogue.name;
        sentences.Clear();
        
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        dialogueOn = false;
        Debug.Log("End of Conversation.");
    }




}

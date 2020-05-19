using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// More info about Dialogue Text from this video: https://www.youtube.com/watch?v=_nRzoTzeyxU
public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Star conversation with " + dialogue.name);

        sentences.Clear();
        //Stopped at 8:04
    }

}

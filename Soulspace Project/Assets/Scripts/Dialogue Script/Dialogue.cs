using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// More info about Dialogue Text from this video: https://www.youtube.com/watch?v=_nRzoTzeyxU
[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public string charName;

    [TextArea(3,10)]
    public string[] sentences;
}

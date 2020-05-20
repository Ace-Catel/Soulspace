using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow4 : MonoBehaviour
{
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");    
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y - 0.25f,-10f);
    }
}

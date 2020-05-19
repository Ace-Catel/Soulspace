using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// More information on this code: https://www.youtube.com/watch?v=LNLVOjbrQj4
public class PlayerAiming : MonoBehaviour
{
    //ESSENTIAL: Aiming
    //Camera Gameobject Variable
    public Camera cam;
    //The aiming controls of the mouse relies on the camera. The camera will check the mouse's position in the camera's field

    //ESSENTIAL: Aiming
    //rb - Rigidbody Component Variable
    public Rigidbody2D rb;

    //ESSENTIAL: Aiming
    //Vector variable for Mouse Position
    Vector2 mousePos;

    void Update()
    {
        //ESSENTIAL: Aiming
        //Variable mousePos will record MOUSE POSITION based on WORLD POINTS from the PERSPECTIVE OF THE CAMERA
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        //ESSENTIAL: Aiming
        //Gets the look direction based on MOUSE POSITION based on WORLD POINTS subtracted by PLAYER'S WORLD POSITION 
        Vector2 lookDir = mousePos - rb.position;

        //ESSENTIAL: Aiming
        //Uses Math Formula "Atan2" to find the angle based on the PLAYER'S POSITION and MOUSE POSITION
        float angle = Mathf.Atan2(lookDir.y,lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}

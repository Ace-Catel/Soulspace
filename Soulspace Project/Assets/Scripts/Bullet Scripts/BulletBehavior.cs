using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    //ESSENTIAL: Hit Effect
    //Declares Gameobject prefab of an after effect
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //ESSENTIAL: Hit Effect
        //Creates Effect after colliding with something, (Quaternion.identity is "No rotation")
        //Declared Game object to modify hit effect to delete itself
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

        //ESSENTIAL: Hit Effect
        //Hit effect will destroy itself after a 1/3 second
        Destroy(effect, 0.4f);

        //ESSENTIAL: Delete Bullet
        //Bullet will delete itself afterwards
        Destroy(gameObject);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    //ESSENTIAL: Hit Effect
    //Declares Gameobject prefab of an after effect
    //public GameObject hitEffect;
    Rigidbody2D bulletRB;
    Animator bulletAnim;
    private void Awake()
    {
        bulletRB = this.GetComponent<Rigidbody2D>();
        bulletAnim = this.GetComponent<Animator>();
        bulletAnim.SetBool("hit", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ESSENTIAL: Hit Effect
        //Creates Effect after colliding with something, (Quaternion.identity is "No rotation")
        //Declared Game object to modify hit effect to delete itself
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        ////ESSENTIAL: Hit Effect
        ////Hit effect will destroy itself after a 1/3 second
        //Destroy(effect, 0.4f);
        //using animator change animation state
        if (!collision.transform.tag.Equals("Player"))
        {
            Debug.Log(collision.transform.name);
            bulletAnim.SetBool("hit", true);
            //ESSENTIAL: Delete Bullet
            //Bullet will delete itself afterwards after 0.4s
            Destroy(gameObject, 0.4f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.transform.tag.Equals("Player") && !collision.transform.tag.Equals("EnemyBullet"))
        { 
            Debug.Log(collision.transform.name);
            bulletAnim.SetBool("hit", true);
            bulletRB.constraints = RigidbodyConstraints2D.FreezeAll;
            GetComponent<CircleCollider2D>().enabled = false;
            //ESSENTIAL: Delete Bullet
            //Bullet will delete itself afterwards after 0.4s
            Destroy(gameObject, 0.4f);
        }
    }


}

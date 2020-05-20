using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    //Don't shoot if dialogue is displayed
    DialogueManager dialogueManager;

    //ESSENTIAL: Player Shooting/Attack
    //Reference the location of where the "Projectile" comes from.
    public Transform firePoint;

    //ESSENTIAL: Player Shooting/Attack
    //Reference the projectile gameobject that will be used.
    public GameObject bulletPrefab;

    //ESSENTIAL: Player Shooting/Attack
    //Determines the speed of the bullet that it created.
    public float bulletForce = 3f;

    float fireRate = 0.25f;
    float timeFireRate = 0f;

    private void Awake()
    {
        timeFireRate = fireRate;
        dialogueManager = GameObject.FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && (timeFireRate >= fireRate) && !dialogueManager.dialogueOn)
        {
            //Comment ID:1
            //ESSENTIAL: Player Shooting/Attack
            //Call function within script
            Shoot();
            timeFireRate = 0;
        }
        else
        {
            timeFireRate += Time.deltaTime * 1f;
        }
    }

    //Comment ID:1
    //ESSENTIAL: Player Shooting/Attack
    //Function that allows player to create a projectile and fire it.
    void Shoot()
    {
        //ESSENTIAL: Player Shooting/Attack
        //Creates projectile GameObject (Prefab, Start position of Bullet, and Rotation)
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        //ESSENTIAL: Player Shooting/Attack
        //Declares Rigidbody of bullet Prefab
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        //ESSENTIAL: Player Shooting/Attack
        //Access bullet rigidbody to modify bullet to add speed and movement (bulletForce)
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}

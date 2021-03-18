using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject ExplosionPrefab;
    public Rigidbody projectilePrefab;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody hitPlayer;
            hitPlayer = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
            hitPlayer.velocity = transform.TransformDirection(Vector3.forward * 100);
        }

        for(var i =0; i < Input.touchCount; ++i)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began )
            {
                Rigidbody clone;
                clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(Vector3.forward * 200);
            }
        }
    }
}

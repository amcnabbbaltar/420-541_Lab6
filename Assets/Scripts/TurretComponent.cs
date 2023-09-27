using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretComponent : MonoBehaviour
{
    public GameObject particleSystemToSpawn;
    public GameObject player;
    public Slider healthBar;
    public Vector3 intialFowardVector;
    public Vector3 playerDirection;
    public float maxAngle = 45;
    public float maxDistance = 100;
    public float health = 100;

    public float awarnessTimer = 0.0f;
    public float fullAwarnessTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        intialFowardVector = transform.forward;  
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {
        
        UpdateTurretRotation();
        UpdateTurretAwareness(SeePlayer());
               
    }
    
    public void UpdateTurretAwareness(bool seePlayer)
    {
       awarnessTimer = (seePlayer)?awarnessTimer + Time.deltaTime : awarnessTimer - Time.deltaTime;
       
       if (awarnessTimer >= fullAwarnessTime)
       {

            // TO DO UPDATE ()
       }
       
    }
    public void ProcessHit()
    {

    }
    public void UpdateTurretRotation()
    {
        if (SeePlayer())
        {
            playerDirection = new Vector3(playerDirection.x,0,playerDirection.z);
            transform.LookAt(player.transform.position + playerDirection);
        }

    }
    public bool SeePlayer()
    {
        return false;
       
    }
}
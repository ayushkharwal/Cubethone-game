﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision CollisionInfo){
        if( CollisionInfo.collider.tag == "Obstacle"){
            Debug.Log("We hit an Obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
   

}

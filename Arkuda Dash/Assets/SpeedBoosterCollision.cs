using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoosterCollision : MonoBehaviour
{ 
    public float boostSpeed;
    public float duration;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player == null) return;
        player.BoostSpeed(boostSpeed, duration);
       
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

public class Gameover : MonoBehaviour
{
    public LayerMask obstacleLayer;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(LayerMask.LayerToName(collision.collider.gameObject.layer) == "Obstacles")
        {
            SceneManager.LoadScene(2);

        }



           
    }






}



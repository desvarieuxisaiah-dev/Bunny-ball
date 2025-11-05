using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // This is a variable for the shockwave. Period
    [SerializeField] GameObject shockwavePrefab;
    // This is a variable for the game manager
    [SerializeField] GameManager gameManager;

    //This function runs once at the beginning of the game
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //Checks if we collide with something tagged as "Player"
        // This function runs when we collide with the trigger
        if (other.CompareTag("Player")) {
            // If we do collide with something tagged as player
            // sets game over to true
            //Gameover is true
            gameManager.gameOver = true;
            Instantiate(shockwavePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
        }// destroys keyf
    }
}

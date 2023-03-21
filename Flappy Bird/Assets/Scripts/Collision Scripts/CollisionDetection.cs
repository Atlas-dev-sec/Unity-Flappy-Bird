using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetection : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip gameOverSound;
    private BirdMovement playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Bird").GetComponent<BirdMovement>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
        
            audioSource.PlayOneShot(gameOverSound);
            playerControllerScript.gameOver = true;
        }
    }

}

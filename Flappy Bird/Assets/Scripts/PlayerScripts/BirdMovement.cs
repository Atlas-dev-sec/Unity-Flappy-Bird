using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 0.5f;
    [SerializeField] float jumpForce = 1f;
    public bool gameOver;
    public AudioClip wingClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
  
    // Update is called once per frame
    void Update()
    {
        UserInput();
    
    }

    private void UserInput()
    {
        if(Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(wingClip);
            rb.AddForce((Vector3.up * jumpForce * Time.deltaTime).normalized, ForceMode.Force);
        }
    }
}

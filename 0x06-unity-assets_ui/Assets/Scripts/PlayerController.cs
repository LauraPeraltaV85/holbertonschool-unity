﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sJump;
    public float gravity = 20.0f;
    //public Rigidbody rb;
    private Vector3 move = Vector3.zero;
    private CharacterController pController;


    public GameObject playerT;
    public Transform respawnPoint;
    public float minHeightForDeath;
    // public Transform respawnTrigger;

    // Start is called before the first frame update
    void Start()
    {
        pController = GetComponent<CharacterController>();
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (pController.isGrounded)
        {
            move = new Vector3(horizontal * speed, 0.0f, vertical * speed);
            move *= speed;
            if (Input.GetButton("Jump"))
                move.y = sJump; 
        }
        else
        {
            float jump = move.y;
            move = new Vector3(horizontal * speed, jump, vertical * speed);
            move.y = jump;
            move = transform.TransformDirection(move);
        }
        move.y -= gravity * Time.deltaTime;
        pController.Move(move * Time.deltaTime);

        if (playerT.transform.position.y < minHeightForDeath)
            playerT.transform.position = respawnPoint.position;       
    }
    
    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.transform == respawnTrigger)
    //         other.transform.position = respawnPoint.position;
    // }
}

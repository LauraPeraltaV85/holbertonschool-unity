using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform playerPos;
    public Vector3 offset;
    // public float speedH = 2.0f;
    // public float speedV = 2.0f;
    // private float x = 0.0f;
    // private float y = 0.0f;
    public bool rotateAround = true;
    public float rotationSpeed = 5.0f;
    public bool LookAtPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.position + offset;
        if (rotateAround)
        {
            if (Input.GetMouseButton(1))
            {
                Quaternion camTurn = 
                    Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
                
                offset = camTurn * offset;
            // x +=speedH * Input.GetAxis("Mouse X");
            // y += speedV * Input.GetAxis("Mouse Y");
            // transform.eulerAngles = new Vector3(y, x, 0.0f);
            }
        }
        if (LookAtPlayer || rotateAround)
            transform.LookAt(playerPos);
    }
}

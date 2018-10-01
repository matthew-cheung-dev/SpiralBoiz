﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private float rotationInDegrees;

    private float yBoundary = 10.0f;
    private float xBoundary = 4.5f;

    private Rigidbody2D rb2d;

    private Sprite sprite;

    public int player_no;

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<Sprite>();

        rotationInDegrees = transform.rotation.eulerAngles.z;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("A_Player" + player_no))
        {
            Debug.Log("Player" + player_no + "A");

            Vector2 force = transform.right * Input.GetAxis("Vertical") * speed;

            rb2d.AddForce(force);
        }


        if (Input.GetButtonDown("B_Player" + player_no))
        {
            Debug.Log("Player" + player_no +" B");
        }



        //UP DOWN JOYSTICK
        if (Input.GetAxis("Vertical_Player" + player_no) > 0)
        {
            Debug.Log("Player" + player_no + "Down");

        }
        if (Input.GetAxis("Vertical_Player" + player_no) < 0)
        {
            Debug.Log("Player" + player_no + "Up");
        }


        //LEFT RIGHT JOYSTICK
        if (Input.GetAxis("Horizontal_Player" + player_no) > 0)
        {
            Debug.Log("Player" + player_no + "Right");

            rotate();

        }
        if (Input.GetAxis("Horizontal_Player" + player_no) < 0)
        {
            Debug.Log("Player" + player_no + "Left");

            rotate();
        }


        //rotate();

        
	}


    private void rotate()
    {
        transform.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal") * rotationSpeed));
    }

    //done
}

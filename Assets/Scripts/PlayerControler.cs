using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float torqueAmount = 1f;
    public float bootSpeed = 15f;
    public float baseSpeed = 5f;
    public SurfaceEffector2D sfe2d;
    public bool canmove = true;
    

    // Start is called before the first frame update
    void Start()
    {
        // sao phai goi rb2d ma ko dung xoay z,
        rb2d = GetComponent<Rigidbody2D>();
        sfe2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (canmove)
        {
            RotatePlayer();
            RespondToBoots();
        }
    }

    public void DisableControls()
    {
        canmove = false;
    }

    void RespondToBoots()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            sfe2d.speed = bootSpeed;
        }
        else
        {
            sfe2d.speed = baseSpeed;
        }
       
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
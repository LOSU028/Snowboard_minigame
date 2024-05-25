using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] float torque = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 20f;
    Rigidbody2D rigidBody2D;
    SurfaceEffector2D surfaceEffector2D;
    bool stopControl = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!stopControl){
            Rotate();
            ResponseBoost();
        }
    }

    public void StopControls(){
        stopControl = true;
    }

    private void ResponseBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2D.speed = boostSpeed;
        }else{
            surfaceEffector2D.speed = normalSpeed;
        }
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody2D.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody2D.AddTorque(torque * -1);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 0f;
    [SerializeField] public float maxSpeed; 
    [SerializeField] protected Rigidbody2D _rigidbody2D;

    [SerializeField] protected Vector3 direction = new Vector3(1,0,0);

    private void Awake()
    {
        _rigidbody2D.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        maxSpeed=LevelManager.instance.gameSpeed;
        GetKey();
        Move();
    }

    void Move()
    {
        this.transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime * speed,
            transform.position.z);
    }

    void GetKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.instance.Play("pressSpace");
            
            if (direction.y == 0) direction.y = -1;
            else direction.y *= -1;
            if (transform.rotation.z == 0)
            {
                transform.Rotate(0.0f, 0.0f, -45.0f, Space.World);
            }
            else
            {
                if (transform.rotation.z <0) transform.Rotate(0.0f, 0.0f, 90f , Space.World);
                else
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.World);
                }
            }
            // reverseGravity();
            if (speed != 0)
            {
                if (speed < 0) speed = -maxSpeed;
                else speed = maxSpeed;
                speed *= -1;
            }
            else speed = maxSpeed;
        }
    }
}

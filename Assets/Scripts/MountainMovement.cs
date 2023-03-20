using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainMovement : MonoBehaviour
{

    [SerializeField] private GameObject mountain;
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        speed = LevelManager.instance.gameSpeed;
        Move();
        Despawn();
    }

    private void Move()
    {
        mountain.transform.position = new Vector3(mountain.transform.position.x - Time.deltaTime * speed,
            mountain.transform.position.y, mountain.transform.position.z);
    }

    private void Despawn()
    {
        if(mountain.transform.position.x<=-30) Destroy(this.gameObject);
    }
}

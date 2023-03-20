using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    
    public float gameSpeed;
    public float score;
    public float tmp;
    public float maxTime = 12f;

    private void Awake()
    {
        instance = this;
    }

    public void init()
    {
        gameSpeed = 5.5f;
        score = 0;
        tmp = 0;
    }

    private void Update()
    {
        score += Time.deltaTime;
        tmp+= Time.deltaTime;
        if (math.ceil(tmp) >= maxTime)
        {
            tmp = 0;
            if (score < 50)
            {
                maxTime += 4;
                gameSpeed = gameSpeed + 1f;
            }
            else
            {
                maxTime += 3;
                gameSpeed = gameSpeed + 0.8f;
            }
        }
    }
}

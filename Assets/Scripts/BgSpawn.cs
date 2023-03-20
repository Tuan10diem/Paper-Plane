using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSpawn : MonoBehaviour
{
    public static BgSpawn instance;
    [SerializeField] protected List<GameObject> bgList;

    private void Awake()
    {
        Instantiate(bgList[0], new Vector3(0,0,0), transform.rotation);
        instance = this;
    }

    public void Spawn()
    {
        int rand = UnityEngine.Random.Range(0, bgList.Count);
        Instantiate(bgList[rand], transform.position, transform.rotation);
    }
}

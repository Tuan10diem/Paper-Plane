using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointCtrl2 : MonoBehaviour
{
    public bool ok = false;
    void Update()
    {
        if (!ok && this.transform.position.x <= Spawner1.instance.transform.position.x)
        {
            ok = true;
            Spawner1.instance.Spawn();
        }
    }
}

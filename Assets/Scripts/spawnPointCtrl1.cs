using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointCtrl1 : MonoBehaviour
{
    public bool ok = false;
    
    void Update()
    {
        if (!ok && this.transform.position.x <= Spawner2.instance.transform.position.x)
        {
            ok = true;
            Spawner2.instance.Spawn();
        }
    }
}

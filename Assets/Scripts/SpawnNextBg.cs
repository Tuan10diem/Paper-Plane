using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNextBg : MonoBehaviour
{
    private bool ok = false;
    
    // Update is called once per frame
    void Update()
    {
        IsSpawn();
    }

    void IsSpawn()
    {
        if (!ok && this.transform.position.x <= 0.2f)
        {
            BgSpawn.instance.Spawn();
            ok = true;
        }
    }
}

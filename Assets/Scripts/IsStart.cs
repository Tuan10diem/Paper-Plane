using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class IsStart : MonoBehaviour
{
    [SerializeField] protected GameObject _textEffect;
    
    [SerializeField] protected GameObject mountainSpawnPoint1, mountainSpawnPoint2;
    
    // Update is called once per frame
    void Update()
    {
        LevelManager.instance.init();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _textEffect.SetActive(true);
            mountainSpawnPoint2.SetActive(true);
            mountainSpawnPoint1.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}

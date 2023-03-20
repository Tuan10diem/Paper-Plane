using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public static Spawner2 instance;
    [SerializeField] public GameObject[] mountainPrefab;

    private void Awake()
    {
        instance = this;
    }

    public void Spawn()
    {
        int rand = UnityEngine.Random.Range(0, mountainPrefab.Length);
        Instantiate(mountainPrefab[rand], transform.position, mountainPrefab[rand].transform.rotation);
    }
}

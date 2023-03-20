using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public static Spawner1 instance;
    [SerializeField] public GameObject[] mountainPrefab;

    private void Awake()
    {
        instance = this;
        Instantiate(mountainPrefab[0], transform.position, mountainPrefab[0].transform.rotation);
    }

    public void Spawn()
    {
        int rand = UnityEngine.Random.Range(0, mountainPrefab.Length);
        Instantiate(mountainPrefab[rand], transform.position, mountainPrefab[rand].transform.rotation);
    }
}

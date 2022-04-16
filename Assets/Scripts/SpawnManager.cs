using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public float spawnrate;

    private void Start()
    {
        InvokeRepeating("spawn", 0, spawnrate);
    }

    public void spawn()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}

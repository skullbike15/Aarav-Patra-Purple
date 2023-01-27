﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Hexagon game object
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    //Spawn rate for how many
    //objects are spawned
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 2f;
    [Header("Default Spawn Time")]
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        //Random range for shape objects to be spawned
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //Spawn new hexagom at position
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}



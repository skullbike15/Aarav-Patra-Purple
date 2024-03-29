﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   

    //Object that we will attach to the script for spawning object
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    //Spawning delay time
    [Header("Default spawn delay time")]
    public float spawnDelay = 1f;
    //Spawning time for each object appearing
    [Header("Default spawn time")]
    public float spawnTime = 2f;
    //Object that we will attach to the script for spawning object
    [Header("ChallengeObj2 Game Object")]
    public GameObject challengeObject2;
    //Spawning delay time
    [Header("Default spawn delay time2")]
    public float spawnDelay2 = 2f;
    //Spawning time for each object appearing
    [Header("Default spawn time2")]
    public float spawnTime2 = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
        InvokeRepeating("InstantiateObjects2", spawnDelay2, spawnTime2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, -4f, 0);
        transform.position = new Vector3(15, -4f, 0);
    }

    void InstantiateObjects ()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }

    
    void InstantiateObjects2()
    {
        Instantiate(challengeObject2, transform.position, transform.rotation);
    }
}

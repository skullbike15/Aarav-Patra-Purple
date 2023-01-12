﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Cube Object")]
    //Cube that is going to be spawn
    public GameObject spawnCube;
    //difficulty of the game
    [Header("Default Difficulty")]
    public float difficulty = 40f;
    //Time for the next cube
    //to be spawned
    float spawn;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        //The next cube to be spawn will
        //be based on the difficulty and
        //game speed
        spawn = difficulty * Time.deltaTime;
        //Difficulty of the game is
    }
}

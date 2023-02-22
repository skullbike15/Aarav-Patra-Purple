using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//User Interference namespace
using UnityEngine.UI;
//Scene Managment namespace
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Current cube game object
    [Header("Cube Object")]
    public GameObject currentCube;
    //Last cube game object
    [Header("Last Cube Object")]
    public GameObject lastCube;
    //Text Object
    [Header("Text object")]
    public Text text;
    //Level number integer
    [Header("Current level")]
    public int level;
    //Booclean determining if game
    //is over
    [Header("Booclean")]
    public bool Done;

    //New block function to create blocks
    //for the game
    void Newblock()
    {
        //If the last one is not
        //destroyed
        if(lastCube != null)
        {
            //The current cube position equals to all 3 axis psoitions
            //to the nearest integer
            currentCube.transform.position = new Vector3(Mathf.Round(currentCube.transform.position.x),
                currentCube.transform.rotation.y,
                Mathf.Round(currentCube.transform.rotation.z));
            //current cubes size equals to the last cube size
            currentCube.transform.localScale = new Vector3(lastCube.transform.localScale.x - Mathf.Abs(currentCube.transform.position.x - lastCube.transform.position.x),
                lastCube.transform.localScale.y,
                lastCube.transform.localScale.z - Mathf.Abs(currentCube.transform.position.z - lastCube.transform.position.z));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update

    //Jumping power for the player object
    [Header("Default Jumping Power")]
    public float jumpPower = 6f;
    //True or false if the object
    //is on the ground
    [Header("Booclean isGrounded")]
    public bool isGrounded = false;
    //Position of the object
    float posX = 0.0f;
    //Rigidbody2D of the object
    Rigidbody2D rb;
    void Start()
    {
        //Variable rb equals to Rigidbody2D
        //component
        rb = transform.GetComponent<Rigidbody2D>();
        //Variable posX equals to position
        //of the object on the x axis
        posX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

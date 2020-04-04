using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBody;

    private float Speed = 10.0f;
    private float HoriMovement = 0.0f;

    private float JumpSpeed = 10.0f;

    private bool CanJump = false;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision TheObject)
    {
        if (TheObject.collider.name == "Platform") CanJump = true;
    }

    void OnCollisionExit(Collision TheObject)
    {
        if (TheObject.collider.name == "Platform") CanJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        string Player = gameObject.name;

        HoriMovement = Input.GetAxis((Player == "Player_1") ? "Horizontal_Player1" : "Horizontal_Player2");
        rigidBody.velocity = new Vector2(HoriMovement * Speed, rigidBody.velocity.y);

        if (CanJump && ((Player == "Player_1" && Input.GetKeyDown("w")) || (Player == "Player_2" && Input.GetKeyDown("up"))))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, JumpSpeed);
        }
    }
}

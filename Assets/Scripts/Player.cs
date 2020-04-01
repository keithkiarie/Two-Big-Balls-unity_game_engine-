using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject Platform;

    private Rigidbody rigidBody;

    private float Speed = 5.0f;
    private float HoriMovement = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Platform = GameObject.Find("Platform");
    }

    // Update is called once per frame
    void Update()
    {
        string Player = gameObject.name;
        HoriMovement = Input.GetAxis((Player == "Player_1") ? "Horizontal_Player1" : "Horizontal_Player2");
        rigidBody.velocity = new Vector2(HoriMovement * Speed, rigidBody.velocity.y);
    }
}

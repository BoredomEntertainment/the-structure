using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    //public Vector2 speed;
    Rigidbody2D rigidBody;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        // move left
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("left");
            pos.x += speed;
            rigidBody.AddForce(pos, ForceMode2D.Force);
        }

        // move right
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("right");
            pos.x -= speed;
            rigidBody.AddForce(pos, ForceMode2D.Force);
        }

        // move down
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("up");
            pos.y += speed;
            rigidBody.AddForce(pos, ForceMode2D.Force);
        }

        // move down
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("down");
            pos.y -= speed;
            rigidBody.AddForce(pos, ForceMode2D.Force);
        }

        // stop
        if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        {
            {
            }
        }
    }
}

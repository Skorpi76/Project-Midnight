using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMove : MonoBehaviour {

    public float speed;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 input = new Vector2();
        if (Input.GetKey(KeyCode.W))
        {
            input.y += 1;           
        }
        if (Input.GetKey(KeyCode.S))
        {
            input.y -= 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            input.x -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            input.x += 1;
        }

        rb.velocity = input.normalized * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSCamera : MonoBehaviour
{
    public float speed;
    private Vector2 moveTo;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	
    // Update is called once per frame
    void FixedUpdate()
    {
        moveTo = SSPlayerController.playerPos;
		rb2d.velocity = new Vector2((moveTo.x - transform.position.x) * speed, (moveTo.y - transform.position.y) * speed); // Make Camera move towards the player
    }
}

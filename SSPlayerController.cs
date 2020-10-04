using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SSPlayerController : MonoBehaviour
{
	private Rigidbody2D rb2d;
	public float speed;
	public float jumpHeight;
	public static Vector2 playerPos;
	private bool onGround = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		playerPos = transform.position;
        float moveX = Input.GetAxis("Horizontal"); 
		rb2d.velocity = new Vector2(moveX * speed, rb2d.velocity.y);
    }
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && onGround)
		{
			if (rb2d.velocity.y < jumpHeight)
			{
				rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
			}
			else
			{
				rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y + (jumpHeight / 2));
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.CompareTag("Finish"))
		{
			SceneManager.LoadScene(3);
		}
		if (coll.CompareTag("Death"))
		{
			SceneManager.LoadScene(2);
		}
		if (coll.CompareTag("Floor"))
		{
			onGround = true;
		}
	}

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.CompareTag("Floor"))
		{
			onGround = false;
		}
	}
}
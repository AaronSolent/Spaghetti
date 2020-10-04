using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TDPlayerController : MonoBehaviour
{
	private Rigidbody2D rb2d;
	public float speed;
	public static Vector2 playerPos;
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
        float moveY = Input.GetAxis("Vertical"); 
		rb2d.AddForce(new Vector2(moveX * speed, moveY * speed));
    }
	
	void OnTriggerEnter2D(Collider2D coll)
	{
 		if (coll.CompareTag("Finish"))
		{
			SceneManager.LoadScene(2);
		}
		if (coll.CompareTag("Death"))
		{
			SceneManager.LoadScene(1);
		}
	}
}

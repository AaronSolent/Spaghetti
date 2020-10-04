using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilCan : MonoBehaviour
{
	public float speed;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, SSPlayerController.playerPos, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

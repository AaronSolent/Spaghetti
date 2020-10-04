using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIO1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2 (Random.Range(-2f,2f),Random.Range(-2f,2f));
		transform.position = new Vector2 (Random.Range(-75f,75f),Random.Range(-75f,75f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

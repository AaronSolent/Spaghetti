using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0,0,Random.Range(0,350));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

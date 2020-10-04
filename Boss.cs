using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
	public int health;
	public static Boss instance;
    // Start is called before the first frame update
    public void Attack()
    {
        health--;
		if(health == 0)
		{
			SceneManager.LoadScene(4);
		}
	}

    // Update is called once per frame
    void Awake()
    {
        instance = this;
    }
}

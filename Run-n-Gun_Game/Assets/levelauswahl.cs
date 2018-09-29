using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelauswahl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("A"))
        {	Debug.Log("test");
            UnityEngine.SceneManagement.SceneManager.LoadScene("lvl_2");
        }
		if (Input.GetButtonDown("X"))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("lvl_1");
		}
		if (Input.GetButtonDown("B"))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("lvl_3");
		}
	}
}

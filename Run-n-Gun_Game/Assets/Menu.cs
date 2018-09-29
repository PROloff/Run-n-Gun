using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown.Equals(2))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Paul_Szene");
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelauswahl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Menü"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("levelauswahlw");
        }
	}
}

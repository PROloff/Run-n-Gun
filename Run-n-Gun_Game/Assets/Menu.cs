using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene("Main",LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("A"))
        {
			SceneManager.UnloadSceneAsync("Main");
            SceneManager.LoadScene("levelauswahl",LoadSceneMode.Additive);
        }
	}
}
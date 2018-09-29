using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_OnEvent : MonoBehaviour {

    public AudioSource Sound1;

    private void Awake()
    {
        Sound1 = GetComponent();
    }

    // Use this for initialization
    void Start () {
		if()
        {
            Sound1.Play();
        } //if
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

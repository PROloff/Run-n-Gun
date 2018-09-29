using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Music_ingame : MonoBehaviour {

    public AudioSource Sound;

    private void Awake()
    {
        Sound = GetComponent<AudioSource>();
    }
    // Use this for initialization
    void Start () {
        Sound.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

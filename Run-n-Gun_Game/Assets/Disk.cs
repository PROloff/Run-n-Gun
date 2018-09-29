using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour {

	// Use this for initialization
	public int m_PlayerNumber = 1;  
	private string m_FireButton;
	private float m_ChargeSpeed = 15f;
	void Start () {
		m_FireButton = "Fire" + m_PlayerNumber;

        // The rate that the launch force charges up is the range of possible forces by the max charge time.
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

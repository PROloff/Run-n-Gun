using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Disk : MonoBehaviour {

	// Use this for initialization
	public int m_PlayerNumber = 1;  
	private string m_FireButton;
	private float m_ChargeSpeed = 25f;
	public Transform m_Shell;
    public AudioSource Source;
    public AudioClip m_ThrowAudio;
	
	private Rigidbody m_Body;

	//public CollisionDetectionMode collisionhandler;
	void Start () {
		m_FireButton = "Fire_P" + m_PlayerNumber;
		m_Body = GetComponent<Rigidbody>();
        // The rate that the launch force charges up is the range of possible forces by the max charge time.
		//m_ChargeSpeed = 15f + GetComponent<Player>().m_Speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (m_FireButton))
		{
			Fire();
		}
	
	}
	 private void Fire ()
    {	
        // Set the fired flag so only Fire is only called once.

        // Create an instance of the shell and store a reference to it's rigidbody.
        Transform shellInstance =
    		Instantiate (m_Shell, transform.position, transform.rotation);
			shellInstance.position += transform.forward*0.6f;
        // Set the shell's velocity to the launch force in the fire position's forward direction.
        shellInstance.GetComponent<Rigidbody>().velocity = m_ChargeSpeed * transform.forward; ;

        Source.clip = m_ThrowAudio;
        Source.Play();
        
       
    }
}

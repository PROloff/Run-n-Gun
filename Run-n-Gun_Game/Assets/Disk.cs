using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour {

	// Use this for initialization
	public int m_PlayerNumber = 1;  
	private string m_FireButton;
	private float m_ChargeSpeed = 15f;
	public Transform m_Shell;
	
	private Rigidbody m_Body;

	//public CollisionDetectionMode collisionhandler;
	void Start () {
		m_FireButton = "Fire" + m_PlayerNumber;
		m_Body = GetComponent<Rigidbody>();
        // The rate that the launch force charges up is the range of possible forces by the max charge time.
    
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

        // Set the shell's velocity to the launch force in the fire position's forward direction.
        shellInstance.GetComponent<Rigidbody>().velocity = m_ChargeSpeed * transform.forward; ;
		
		
        // Change the clip to the firing clip and play it.

         // m_ShootingAudio.clip = m_FireClip;
         // m_ShootingAudio.Play ();
        
       
    }
}

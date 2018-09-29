using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour {

	// Use this for initialization
	public int m_PlayerNumber = 1;  
	private string m_FireButton;
	private float m_ChargeSpeed = 15f;
	private bool m_Fired;
	public Transform m_FireTransform;
	public Rigidbody m_Shell;
	void Start () {
		m_FireButton = "Fire" + m_PlayerNumber;

        // The rate that the launch force charges up is the range of possible forces by the max charge time.
    
	}
	
	// Update is called once per frame
	void Update () {
		if (!m_Fired && Input.GetButtonDown (m_FireButton))
		{
			Fire();
		}
		
	}
	 private void Fire ()
    {
        // Set the fired flag so only Fire is only called once.
        m_Fired = true;

        // Create an instance of the shell and store a reference to it's rigidbody.
        Rigidbody shellInstance =
            Instantiate (m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

        // Set the shell's velocity to the launch force in the fire position's forward direction.
        shellInstance.velocity = m_ChargeSpeed * m_FireTransform.forward; ;

        // Change the clip to the firing clip and play it.

       // m_ShootingAudio.clip = m_FireClip;
       // m_ShootingAudio.Play ();

        // Reset the launch force.  This is a precaution in case of missing button events.
       
    }
}

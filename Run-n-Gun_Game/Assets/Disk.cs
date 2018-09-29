using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Disk : MonoBehaviour
{

    // Use this for initialization
    public int m_PlayerNumber = 1;
    private string m_FireButton;
    private float m_ChargeSpeed = 25f;
    public Transform m_Shell;
    public Transform arrow;
    public AudioSource Source;
    public AudioClip m_ThrowAudio;

    private Rigidbody m_Body;

    private Transform shell;

    //public CollisionDetectionMode collisionhandler;
    void Start()
    {
        shell = null;
        m_FireButton = "Fire_P" + m_PlayerNumber;
        m_Body = GetComponent<Rigidbody>();
        // The rate that the launch force charges up is the range of possible forces by the max charge time.
        //m_ChargeSpeed = 15f + GetComponent<Player>().m_Speed;
    }

    // Update is called once per frame
    void Update()
    {
        var m_VerticalInputValue = Input.GetAxis("Vertical2_P" + m_PlayerNumber);
        var m_HorizontalInputValue = Input.GetAxis("Horizontal2_P" + m_PlayerNumber);
        if (m_VerticalInputValue != 0 || m_HorizontalInputValue != 0)
        {
            Vector3 direction = new Vector3(m_HorizontalInputValue, 0, m_VerticalInputValue);
            direction.Normalize();
            arrow.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }
        if (Input.GetButtonDown(m_FireButton) && shell == null)
        {
			
            Fire();
        }

    }
    private void Fire()
    {
        Debug.Log("Test");
        // Create an instance of the shell and store a reference to it's rigidbody.
        shell =
            Instantiate(m_Shell, transform.position, transform.rotation);
        shell.position += arrow.forward * 0.6f;
        // Set the shell's velocity to the launch force in the fire position's forward direction.
        shell.GetComponent<Rigidbody>().velocity = m_ChargeSpeed * arrow.forward;
    }
}

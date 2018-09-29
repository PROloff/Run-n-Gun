using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Use this for initialization
    public float m_Speed = 12f;                 // How fast the tank moves forward and back.
    public float m_TurnSpeed = 180f;
    private Rigidbody m_Rigidbody;
    private float m_VerticalInputValue;
    private float m_HorizontalInputValue;
    public int playernummer = 1;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        m_VerticalInputValue = Input.GetAxis("Vertical_P" + playernummer);
        m_HorizontalInputValue = Input.GetAxis("Horizontal_P" + playernummer);
    }

    private void FixedUpdate()
    {
        // Adjust the rigidbodies position and orientation in FixedUpdate.
        Move();
    }


    private void Move()
    {
        Vector3 direction = new Vector3(m_HorizontalInputValue, 0, m_VerticalInputValue);
        // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
        Vector3 movement = direction * m_Speed * Time.deltaTime;

        // Apply this movement to the rigidbody's position.
        m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Disk")
        {
            Destroy(this.gameObject);
        }

    }
}



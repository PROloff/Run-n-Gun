using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionhandler : MonoBehaviour
{

    // Use this for initialization
    public Player player;
    private int collisions = 0;

    private int collisionsP = 0;

    public bool exist = false;
    void Start()
    {
        player = this.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Character" && collisionsP != 1)
        {
            collisionsP++;
        }
        else if (col.gameObject.name == "Character")
        {
            //Player hit
            Destroy(this.gameObject);
            exist = false;
        }

        if (collisions != 4)
        {
            collisions++;
        }
        else
        {
            Destroy(this.gameObject);
            exist = false;
        }

    }
}

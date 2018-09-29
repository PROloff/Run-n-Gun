using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_player : MonoBehaviour
{

    // Use this for initialization
    private int leben;

    void Start()
    {
        leben = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Disk" && leben > 1)
        {
            leben--;
        }
        else if (col.gameObject.name == "Disk" && leben == 1)
        {
            Destroy(this.gameObject);
        }
    }
}

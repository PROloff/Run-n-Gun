using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionhandler : MonoBehaviour {

	// Use this for initialization
	public Player player;
	void Start () {
		player = this.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision col)
    {
		
        if(col.gameObject.name == "Player" || col.gameObject.name == "Disc (Clone)" || col.gameObject.name == "Walltop" || col.gameObject.name == "Wallleft" || col.gameObject.name == "Walldown" || col.gameObject.name == "Wallright")
        {
           // Destroy(this.gameObject);
        }
    }
}

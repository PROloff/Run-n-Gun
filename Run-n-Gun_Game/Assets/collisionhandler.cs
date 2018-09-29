using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionhandler : MonoBehaviour {

	// Use this for initialization
	public Player player;
	private int collisions =0;
	void Start () {
		player = this.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision col)
    {
		
		switch (collisions)
		{
			case 0: collisions++;
					break;
			case 1: collisions++;
					break;
			case 2: Destroy(this.gameObject);
					break;
		}
        /*if(col.gameObject.name == "Player" || col.gameObject.name == "Disc (Clone)" || col.gameObject.name == "Walltop" || col.gameObject.name == "Wallleft" || col.gameObject.name == "Walldown" || col.gameObject.name == "Wallright")
        {
           // Destroy(this.gameObject);
        } 
		*/
    }
}

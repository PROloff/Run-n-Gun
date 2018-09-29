using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armDisk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(ArmDisk());
	}
	
	// Update is called once per frame

	IEnumerator ArmDisk() 
	{
		yield return new WaitForSeconds(0.2f);
		this.GetComponent<CapsuleCollider>().enabled = true;
	}
}

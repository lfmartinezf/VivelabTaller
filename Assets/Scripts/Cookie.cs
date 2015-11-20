using UnityEngine;
using System.Collections;

public class Cookie : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
	
		gameObject.SetActive(false);
		Debug.Log ("ñam ñam comida");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

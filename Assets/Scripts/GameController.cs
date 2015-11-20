using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject SuperCookie;

	private GameObject activeSuperCookie;  //se crea la instancia

	// Use this for initialization
	void Start () {
		activeSuperCookie = Instantiate(SuperCookie);
		StartCoroutine(ScheduleCookieDestroy());
	}
	
	// Update is called once per frame
	IEnumerator ScheduleCookieDestroy () { //timer para que se destruya la galleta
			yield return new WaitForSeconds(3.0f);
			Destroy(activeSuperCookie);
	}
}

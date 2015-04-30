using UnityEngine;
using System.Collections;

public class ChangeLevel1 : MonoBehaviour {
	
	void OnTriggerEnter (Collider enter) {
		if (enter.tag == "Entrance"){
			Debug.Log ("Hello");
			Application.LoadLevel ("Main"); 
		}
	}
}

using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	void OnTriggerEnter (Collider enter) {
		Debug.Log ("Collided");
		Debug.Log (enter.tag);
		if (enter.tag == "Entrance"){
			Debug.Log ("Entered");
			Application.LoadLevel ("Fight"); 
		}
	}
}

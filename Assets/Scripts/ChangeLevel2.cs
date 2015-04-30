using UnityEngine;
using System.Collections;

public class ChangeLevel2 : MonoBehaviour {

	void OnTriggerEnter (Collider enter) {
		if (enter.tag == "Entrance"){
			Application.LoadLevel ("Fight"); 
		}
	}
}

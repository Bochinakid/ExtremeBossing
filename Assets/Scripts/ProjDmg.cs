using UnityEngine;
using System.Collections;

public class ProjDmg : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Debug.Log ("Entered");
		if (col.gameObject.tag == "Enemy") {
			Debug.Log ("Hit Enemy");
			col.gameObject.GetComponent<EnemyHealth> ().currentHealth -= 10;
		} else {
			Destroy (gameObject);
		}
	}
}

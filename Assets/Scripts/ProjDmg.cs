using UnityEngine;
using System.Collections;

public class ProjDmg : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Enemy") {
			col.gameObject.GetComponent<EnemyHealth> ().currentHealth -= 10;
		}
		else if (col.gameObject.tag == "Boss") {
			col.gameObject.GetComponent<BossHealth> ().health -= 10;
		}
	} 
}
using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {

	public float health = 1000f;
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
			Destroy (gameObject);
	}
}

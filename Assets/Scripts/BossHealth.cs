using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {

	public float health = 300f;
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
			Destroy (gameObject);
	}
}

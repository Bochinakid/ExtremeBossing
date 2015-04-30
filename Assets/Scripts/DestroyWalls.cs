using UnityEngine;
using System.Collections;

public class DestroyWalls : MonoBehaviour {

	public bool destroy;

	void FixedUpdate () {
		if (destroy)
			Destroy (gameObject);
	}
}

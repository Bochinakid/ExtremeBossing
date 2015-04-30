using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int currentHealth;
	public int startHealth = 100;

	// Use this for initialization
	void Awake () {
		currentHealth = startHealth;
	}
}

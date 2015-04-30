using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	Animator anim;
	public int currentHealth;
	public int startHealth = 100;

	// Use this for initialization
	void Awake () {
		currentHealth = startHealth;
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (currentHealth <= 0)
			anim.SetInteger ("Dead", 1);
	}
}

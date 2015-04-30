using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	Animator anim;
	public int currentHealth;
	public int startHealth = 100;
	public bool isDead = false;
	public AudioClip Hit;

	// Use this for initialization
	void Awake () {
		currentHealth = startHealth;
		anim = GetComponent<Animator> ();
	}

	void Update () {
		GetComponent<AudioSource>().PlayOneShot(Hit);
		if (currentHealth <= 0 && !isDead) {
			Destroy(gameObject);
		}
	}
}

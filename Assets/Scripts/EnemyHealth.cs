using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	Animator anim;
	Transform counter;
	EnemyCounter count;
	public int currentHealth;
	public int startHealth = 100;
	public bool isDead = false;
	public AudioClip Hit;

	// Use this for initialization
	void Awake () {
		currentHealth = startHealth;
		anim = GetComponent<Animator> ();
		counter = GameObject.FindGameObjectWithTag ("Counter").transform;
		count = counter.GetComponent <EnemyCounter> ();
	}

	void Update () {
		GetComponent<AudioSource>().PlayOneShot(Hit);
		if (currentHealth <= 0 && !isDead) {
			count.AddEnemy();
			Destroy(gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class BossAI : MonoBehaviour {

	Transform player;
	float shotForce = 1000f;
	float fireTime;
	float rotationSpeed = 5f;

	public Transform shotPos;
	public Rigidbody pumpkin;
	public float cooldown = 1f;

	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update() {

		Ray ray = new Ray (transform.position, player.transform.position);
		RaycastHit hit;

		Debug.DrawRay (transform.position, player.transform.position, Color.green);

		if (Physics.Raycast (ray, out hit)) {
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), rotationSpeed*Time.deltaTime);
		}

		if (Time.time >= fireTime) {
			Attack ();
		}
	}

	void Attack() {
		Rigidbody newArrow = Instantiate (pumpkin, shotPos.position, shotPos.rotation) as Rigidbody;
		Physics.IgnoreCollision(newArrow.GetComponent<Collider>(), GetComponent<Collider>());
		newArrow.AddForce (shotPos.forward * shotForce);

		Destroy (newArrow.gameObject, 3);

		fireTime = Time.time + cooldown;
	}
}

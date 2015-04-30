using UnityEngine;
using System.Collections;

public class PlayerRanged : MonoBehaviour {
	
	public Rigidbody arrow;
	public Transform bowPos;
	public float speed = 10f;
	public float shotForce = 1000f;
	public AudioClip Throw;
	float cooldown = 0.5f;
	float timer;
	
	// Update is called once per frame
	void Update () {		
		timer += Time.deltaTime;

		if(Input.GetButtonUp("Fire1")) {
			if(timer >= cooldown)
				Attack ();
		}
	}

	void Attack() {
		GetComponent<AudioSource>().PlayOneShot(Throw);
		Rigidbody newArrow = Instantiate (arrow, bowPos.position, bowPos.rotation) as Rigidbody;
		Physics.IgnoreCollision(newArrow.GetComponent<Collider>(), GetComponent<Collider>());
		newArrow.AddForce (bowPos.forward * shotForce);
		
		Destroy (newArrow.gameObject, 3);
	}
}


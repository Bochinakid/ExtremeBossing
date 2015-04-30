using UnityEngine;
using System.Collections;

public class EnemyCounter : MonoBehaviour {

	public float slainEnemies = 0;
	Transform fireWall;
	GameObject entrance;
	DestroyWalls dest;

	void Awake() {
		entrance = GameObject.FindGameObjectWithTag ("Entrance");
		fireWall = GameObject.FindGameObjectWithTag ("FireWall").transform;
		dest = fireWall.GetComponent <DestroyWalls> ();
	}

	void Update () {
		if (slainEnemies > 5) {
			DestroyWall ();
		}
	}

	public void AddEnemy () {
		slainEnemies += 1;
	}

	void DestroyWall () {
		dest.destroy = true;
	}
}

using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public GameObject deathParticles;
	public int health;
	//private Vector3 spawn;

	// Use this for initialization
	void Start () {
		//spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && health > 0) {
			health--;
		}

		if (Input.GetMouseButtonDown(0) && (health ==0))
		{
			Instantiate(deathParticles, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}

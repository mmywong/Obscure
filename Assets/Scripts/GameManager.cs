using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int currentscore;
	//public int highscore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time == 2) {
			Vector3 rand_pos = new Vector3(Random.Range(-500,500), Random.Range(-250,250), 0);
			Cat = Instantiate(Cat, rand_pos, Quaternion.identity);
		}
	}
}

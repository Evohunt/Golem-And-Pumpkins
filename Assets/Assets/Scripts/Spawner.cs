using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject pumpkin;

	void Start () {
		
		StartCoroutine(StartSpawning());

	}

	IEnumerator StartSpawning() {

		yield return new WaitForSeconds (Random.Range(2f, 3.5f));
		Instantiate (pumpkin, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);

		StartCoroutine(StartSpawning());

	}
	
	
} // class
















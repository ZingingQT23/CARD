using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerParent : MonoBehaviour {

	private Spawner[] spawners;
	private float naziStartTime;
	private float rightStartTime;
	private float naziTimeSince;
	private float rightTimeSince;
	public float naziSpawnTime;
	public float rightSpawnTime;
	public GameObject nazi;
	public GameObject right;

	void Start () {
		spawners = GetComponentsInChildren<Spawner> ();
		naziStartTime = Time.time;
		rightStartTime = Time.time;
	}

	void Update(){
		naziTimeSince = Time.time;
		rightTimeSince = Time.time;

		//Spawn after a certain amount of time has passed
		if (naziTimeSince >= (naziStartTime + naziSpawnTime)) {
			SpawnHere (nazi);
			naziStartTime = naziTimeSince;
		}

		if (rightTimeSince >= (rightStartTime + rightSpawnTime)) {
			SpawnHere (right);
			rightStartTime = rightTimeSince;
		}
	}


	//Choose a random spawner
	void SpawnHere (GameObject thisAttacker){
		int spawnerNumber = Random.Range (0, spawners.Length);
		Spawner thisSpawner = spawners [spawnerNumber];
		thisSpawner.Spawn (thisAttacker);
		//Debug.Log (toSpawn);
	}

}

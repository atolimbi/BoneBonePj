using UnityEngine;
using System.Collections;

public class GeneratorSimpleEnemies : MonoBehaviour {

	public int timeBetweenEnemies;
	public GameObject[] enemyBombs;

	private float timeRef;
	private int amountPossibleBombs;
	private float screenHeightWorldunits;

	void Start () {
		
		timeRef = timeBetweenEnemies;
		amountPossibleBombs = enemyBombs.Length;
		screenHeightWorldunits = Screen.height / 6.4f;
	}
	
	// Update is called once per frame
	void Update () {

		if ((timeRef - Time.time) <= 0) {

			CreateEnemySimple ();

		}
	}

	void CreateEnemySimple ()
	{
		timeRef = timeRef + timeBetweenEnemies;
		Vector3 positionEnem = new Vector3 (Random.Range(15f, 65f), screenHeightWorldunits + 3, 0f);
		int indexEnemy = Random.Range (0, amountPossibleBombs);
		Instantiate (enemyBombs [indexEnemy], positionEnem, Quaternion.identity);
	}
}

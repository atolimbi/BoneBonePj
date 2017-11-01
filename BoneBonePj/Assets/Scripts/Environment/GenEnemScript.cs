using UnityEngine;
using System.Collections;

public class GenEnemScript : MonoBehaviour {


	public int timeBetweenEnemies;
	public GameObject[] balls;
	public Transform limitLeft;
	public Transform limitRight;

	private float timeRef;
	private int qtyBalls;
	private float limLeft;
	private float limRight;
	// Use this for initialization
	void Start () {
		timeRef = timeBetweenEnemies;
		qtyBalls = balls.Length;
		limLeft = limitLeft.position.x;
		limRight = limitRight.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		if ((timeRef - Time.time) <= 0) {

			//Debug.Log ("crear");
			timeRef = timeRef + timeBetweenEnemies;
			Vector3 positionEnem = new Vector3 (Random.Range(limLeft, limRight), transform.position.y, 0f);
			int posBall = Random.Range (0, qtyBalls);

			Instantiate (balls [posBall], positionEnem, Quaternion.identity);

		}
			
	}
}

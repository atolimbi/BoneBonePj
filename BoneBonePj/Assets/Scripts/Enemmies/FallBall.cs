using UnityEngine;
using System.Collections;

public class FallBall : MonoBehaviour {

	public float advY;


	private Vector3 posBall;
	// Use this for initialization
	void Start () {

		posBall = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		posBall.y = posBall.y - advY;
		transform.position = posBall;
	
	}
}

using UnityEngine;
using System.Collections;

public class SimpleFallingEnemy : MonoBehaviour {

	public float fallingSpeed;

	void Update () {
		//Debug.Log (fallingSpeed);
		transform.Translate((Vector3.down * fallingSpeed * Time.deltaTime), Space.Self);
	}
}

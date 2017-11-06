using UnityEngine;
using System.Collections;

public class SimpleFallingEnemy : MonoBehaviour {

	public float fallingSpeed;

	void Update () {
		transform.Translate((Vector3.down * fallingSpeed * Time.deltaTime), Space.Self);
	}
}

using UnityEngine;
using System.Collections;

public class PointToMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		/*===========================================
		Rotation code taken from Youtube
		Author = Krister Cederlund
		LinkSource = www.youtube.com/watch?v=mKLp-2iseDc
		=============================================*/

		Vector2 direction = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		float angle = Mathf.Atan2 (direction.y,direction.x) * Mathf.Rad2Deg;
		Debug.Log (angle);
		Quaternion rotation = Quaternion.AngleAxis (angle - 90, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.05f );
	
	}
}

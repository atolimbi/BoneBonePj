using UnityEngine;
using System.Collections;

public class RotArrow : MonoBehaviour {

	public Camera theCamera;
	public float angleLimit;
	private Quaternion quaternionVer;

	// Use this for initialization
	void Start () {

		//Debug.Log ("perro");
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("perro");
		/////////// Arrow Rotation to follow Mouse //////

		/*Vector3 posMouse = theCamera.ScreenToWorldPoint (Input.mousePosition);
		Vector2 point_1 = new Vector2(transform.position.x, transform.position.y);
		Vector2 point_2 = new Vector2 (posMouse.x, posMouse.y);

		quaternionVer = Quaternion.LookRotation (Vector3.forward, point_2 - point_1);

		//Debug.Log (quaternionVer.eulerAngles.z);*/

		////////// Arrow rotation limited to be between 60 and -60 ////////////////// 

		/*if ((quaternionVer.eulerAngles.z <= angleLimit && quaternionVer.eulerAngles.z >= 0) || (quaternionVer.eulerAngles.z <= 360 && quaternionVer.eulerAngles.z >= 360-angleLimit)) {

			transform.rotation = Quaternion.LookRotation (Vector3.forward, point_2 - point_1);
			Debug.Log ("Hello");
		}*/


		//Debug.Log (transform.rotation.eulerAngles);


	
	}
}

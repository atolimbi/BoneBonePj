using UnityEngine;
using System.Collections;
using System;
using System.Xml.Linq;

public class RotationCanon : MonoBehaviour {

	public float angRot;
	public Camera myCamera;

	private float longX;
	private float longY;
	private float difAng;
	private Vector3 mouseCoord;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



		//transform.Rotate (Vector3.forward * 60 * Time.deltaTime);
		mouseCoord = myCamera.ScreenToWorldPoint(Input.mousePosition);

		Vector3 targetDir = mouseCoord - transform.position;
		float angMouse = (Mathf.Atan(targetDir.y/targetDir.x)) * Mathf.Rad2Deg;
		longY = mouseCoord.y - transform.position.y;

		//Debug.Log (transform.position.y);

		if (longY > 0.3) {

			if (transform.rotation.eulerAngles.z < 90 && transform.rotation.eulerAngles.z >= 0) {
				//Debug.Log ("cuadrante izq");
				angMouse = angMouse + 90;
				//Debug.Log (angMouse);

				if (angMouse < 90 && angMouse > 0) {

					difAng = angMouse - transform.rotation.eulerAngles.z;
					if (difAng > 0) {
						transform.Rotate (Vector3.forward * angRot * Time.deltaTime);
					}
					if (difAng < 0) {
						transform.Rotate (Vector3.forward * (angRot*-1) * Time.deltaTime);
					}
				} 
				else {
					
					transform.Rotate (Vector3.forward * (angRot*-1) * Time.deltaTime);
				}
			}

			else if (transform.rotation.eulerAngles.z < 360 && transform.rotation.eulerAngles.z >= 270) {

				//Debug.Log ("cuadrante der");
				angMouse = angMouse + 270;
				//Debug.Log (angMouse);

				if (angMouse < 360 && angMouse > 270) {

					difAng = angMouse - transform.rotation.eulerAngles.z;
					if (difAng > 0) {
						transform.Rotate (Vector3.forward * angRot * Time.deltaTime);
					}
					if (difAng < 0) {
						transform.Rotate (Vector3.forward * (angRot*-1) * Time.deltaTime);
					}
				} 
				else {

					transform.Rotate (Vector3.forward *(angRot) * Time.deltaTime);
				}
			}
		}

		//float angMouse = Vector3.Angle (targetDir, transform.forward);

		//longX = mouseCoord.x - transform.position.x;

		/*if (longX > 0) {

			angMouse = angMouse + 270;
			transform.Rotate (Vector3.forward * (angRot * -1) * Time.deltaTime);
		}*/
		/*if (longX < 0) {

			angMouse = angMouse + 90;
			transform.Rotate (Vector3.forward * angRot * Time.deltaTime);
		}*/



		//Debug.Log (angMouse);
		//Debug.Log ("rotCannon");
		//Debug.Log (transform.eulerAngles.z);

		//Debug.Log (transform.eulerAngles.z);
		//longY = mouseCoord.y - transform.position.y;
		//Debug.Log ("X: " + longX + "- Y: " + longY);
		//Debug.Log(longX);
		//float angRot = (Mathf.Atan(longY/longX)) * Mathf.Rad2Deg;//degrees between origin and mouse position
		//Debug.Log (angRot);
		//Debug.Log (transform.localRotation.eulerAngles.z);

		/*if(longX > 0) {

			float fRot = (90 - angRot);
			transform.Rotate (Vector3.forward * (fRot * -1) * Time.deltaTime);
		} 
		if (longX < 0) {
			float fRot = (90 + angRot);
			Debug.Log (fRot);
			transform.Rotate (Vector3.forward * (fRot) * Time.deltaTime);
		}*/

		//if (transform.localRotation.eulerAngles.z < anglim1 || transform.localRotation.eulerAngles.z > anglim2) { // to give reestriction to the rotation

		//}

		/*if(longX < 0){

			transform.Rotate(Vector3.forward * angRot * Time.deltaTime);
		}*/
		/*if(longX > 0){

			transform.Rotate(Vector3.forward * (angRot*-1) * Time.deltaTime);
		}*/

	}
}

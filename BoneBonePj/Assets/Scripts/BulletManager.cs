using UnityEngine;
using System.Collections;

public class BulletManager : MonoBehaviour {

	public GameObject[] bulletTypes;
	public GameObject bulletOnCannon;



	private int currentBulletType;
	private int qtyBulletTypes;

	void Start () {
		
		currentBulletType = 0;
		qtyBulletTypes = bulletTypes.Length - 1;
		bulletOnCannon = bulletTypes [currentBulletType];

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			ChangeBullet ();
		}
	}

	void ChangeBullet(){
		if (currentBulletType >= qtyBulletTypes) {
			currentBulletType = 0;
		}
		else {
			currentBulletType++;
		}
		bulletOnCannon = bulletTypes [currentBulletType];
	}
		
}

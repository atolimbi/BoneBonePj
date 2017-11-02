using UnityEngine;
using System.Collections;

public class BulletManager : MonoBehaviour {

	public GameObject[] bulletTypes;
	public GameObject bulletOnCannon;
	public int bulletsOnScreen;
	public int ammoCannon;


	private int currentBulletType;
	private int qtyBulletTypes;

	void Start () {
		
		currentBulletType = 0;
		qtyBulletTypes = bulletTypes.Length - 1;
		bulletOnCannon = bulletTypes [currentBulletType];
		bulletsOnScreen = 0;

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

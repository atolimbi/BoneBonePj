using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunScript : MonoBehaviour {

	/*public GameObject[] bullets;
	public Text mainCanvasBullets;
	public Text mainCanvasSpeed;
	public float timeBetweenShots;
	//public string cannonTagName;
	//public int forceBullettemp;
	//public int amountOfBullets;

	public _GunProperties gunProps;


	//private string cannonTagName;
	private float timeStamp;
	// Use this for initialization
	void Start () {

		gunProps = new _GunProperties ();
		gunProps.posBullet = 0;
		gunProps.typeBullet = bullets.Length;
		gunProps.forceBullet = 40;
		gunProps.amountBullets = 15;
		mainCanvasBullets.text = gunProps.amountBullets.ToString ();
		mainCanvasSpeed.text = "Normal";
		//cannonTagName = this.gameObject.tag;
		//myselfCannon = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {

			timeBetweenShots = 0.5f;
			mainCanvasSpeed.text = "Fast";
		}


		//Debug.Log (gunProps.forceBullet);
		//detect the left click on the mouse
		if(Input.GetMouseButtonDown(1)){

			gunProps.posBullet++;
			if (gunProps.posBullet == gunProps.typeBullet) {
				gunProps.posBullet = 0;
			}
			//Debug.Log (gunProps.posBullet);
		}

		if (Input.GetMouseButtonDown (0) && Time.time >= timeStamp) {

			//Debug.Log ("tiempo cumplido");
			if (gunProps.amountBullets > 0) {
				
				GameObject bullet = Instantiate (bullets[gunProps.posBullet],transform.position,transform.rotation) as GameObject;
				bullet.GetComponent<BulletScript>().canonProps = gunProps;//this gets the public var gunProps and send it to the prefab created (in this case the bullet prefab)
				Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D> ();
				rbBullet.AddForce (transform.up*gunProps.forceBullet,ForceMode2D.Force);
				timeStamp = Time.time + timeBetweenShots;
				gunProps.amountBullets--;
				mainCanvasBullets.text = gunProps.amountBullets.ToString ();
				//Debug.Log ("ahora tengo: " + gunProps.amountBullets);

			}
				
		}
	
	}*/
}

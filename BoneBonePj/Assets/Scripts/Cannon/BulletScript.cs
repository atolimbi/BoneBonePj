using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class BulletScript : MonoBehaviour {


	//public string cannonTagName;
	//public GameObject cannon;
	//public Text mainCanvasBullets;
	public _GunProperties canonProps;


	private SpriteRenderer bulletSpriteRenderer;
	private Text mainCanvasBullets;

	// Use this for initialization
	void Start () {

		bulletSpriteRenderer = GetComponent<SpriteRenderer> ();
		mainCanvasBullets = GameObject.FindGameObjectWithTag ("bulletsUICanvas").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == bulletSpriteRenderer.sprite.name) {


			canonProps.amountBullets++;
			Debug.Log (canonProps.amountBullets);
			mainCanvasBullets.text = canonProps.amountBullets.ToString();
			Destroy (this.gameObject);
			Destroy (other.gameObject);

		} 
		else {

			canonProps.amountBullets++;
			mainCanvasBullets.text = canonProps.amountBullets.ToString();
			Destroy (this.gameObject);

		}
	}

	/*void OnBecameInvisible(){

		Debug.Log ("sali");
		canonProps.amountBullets++;
		mainCanvasBullets.text = canonProps.amountBullets.ToString();
		Destroy (this.gameObject);

	}*/

}

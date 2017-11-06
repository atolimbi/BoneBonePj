using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class BulletScript : MonoBehaviour {

	private BulletManager bulletManager;

	void Start()
	{
		bulletManager = GameObject.FindObjectOfType<BulletManager> ();
	}
		
	void OnTriggerEnter2D (Collider2D collider)
	{
		switch (this.name) {

		case("BulletBlue(Clone)"):
			if (collider.name == "BlueSimpleEnemy(Clone)") {
				Destroy (collider.gameObject);
			}
			DestroyRepetitiveActions ();
			break;

		case("BulletGreen(Clone)"):
			if (collider.name == "GreenSimpleEnemy(Clone)") {
				Destroy (collider.gameObject);
			}
			DestroyRepetitiveActions ();
			break;

		case("BulletRed(Clone)"):
			if (collider.name == "RedSimpleEnemy(Clone)") {
				Destroy (collider.gameObject);
			}
			DestroyRepetitiveActions ();
			break;
		
		default:
			DestroyRepetitiveActions ();
			break;
		}
	}

	void DestroyRepetitiveActions(){

		DestroyObject (this.gameObject);
		bulletManager.ammoCannon++;
		bulletManager.bulletsOnScreen--;
	}
}

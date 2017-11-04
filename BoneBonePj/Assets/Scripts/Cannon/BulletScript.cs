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
		DestroyObject (this.gameObject);
		bulletManager.ammoCannon++;
		bulletManager.bulletsOnScreen--;
	}
}

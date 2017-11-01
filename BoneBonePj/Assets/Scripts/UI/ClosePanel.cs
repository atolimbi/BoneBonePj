using UnityEngine;
using System.Collections;

public class ClosePanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void closePlanel(){

		this.gameObject.SetActive (false);
		Time.timeScale = 1;
	}
}

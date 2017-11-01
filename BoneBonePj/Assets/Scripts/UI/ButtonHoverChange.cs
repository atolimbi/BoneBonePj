using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

	public Text closeText;

	// Use this for initialization
	void Start () {

		Time.timeScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter(PointerEventData eventData){

		closeText.color = Color.white;
		
	}

	public void OnPointerExit(PointerEventData eventData){

		closeText.color = Color.black;

	} 
}

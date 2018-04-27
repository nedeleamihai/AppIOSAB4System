using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour {

	public Image image;
	public Text Name;

	// Use this for initialization
	void Start () {
		
	}
	
	public void Create(Developer developer){
		image.sprite = developer.image;
		Name.text = developer.Name;
	}
}

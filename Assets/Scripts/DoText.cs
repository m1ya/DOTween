using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoText : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.DOText ("Hello", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

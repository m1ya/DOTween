using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOScale (new Vector3(2,1,3), 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

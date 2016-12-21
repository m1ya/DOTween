using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {

		transform.DORotate (new Vector3 (0, 270, 0), 3f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

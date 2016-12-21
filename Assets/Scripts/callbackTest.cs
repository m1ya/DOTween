using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class callbackTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOMove (Vector3.one * 3,2f).OnComplete (() => {
			Debug.Log ("Complete");
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

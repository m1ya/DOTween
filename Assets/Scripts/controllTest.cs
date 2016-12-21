using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class controllTest : MonoBehaviour {

	Tweener tween;

	// Use this for initialization
	void Start () {
		tween = transform.DOMove (Vector3.one * 3, 2f).SetAutoKill(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			tween.Pause ();
		}
		if (Input.GetKey (KeyCode.S)) {
			tween.Play ();
		}
		if (Input.GetKey (KeyCode.R)) {
			tween.Restart ();
		}
		if (Input.GetKey (KeyCode.K)) {
			tween.Kill();
		}
	}
}

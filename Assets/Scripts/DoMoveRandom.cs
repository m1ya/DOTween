using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoMoveRandom : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			transform.DOMove (new Vector3 (Random.Range (5, -5), 0, Random.Range (5, -5)),1f);
		}
	}
}

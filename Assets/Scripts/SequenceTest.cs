using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SequenceTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Sequence sequence = DOTween.Sequence ();
		sequence.Append(transform.DOMove(Vector3.one * 3,2f));
		sequence.Append(transform.DOMove (Vector3.one * (-3), 2f));
	}
	
	// Update is called once per frame
	void Update () {
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoMoveRect : MonoBehaviour {

	RectTransform image;

	// Use this for initialization
	void Start () {
		image = GetComponent<RectTransform> ();
		image.DOLocalMoveX (100, 2f);
	}

}

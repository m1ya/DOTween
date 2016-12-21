using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoMove : MonoBehaviour {

	// Use this for initialization
	void Start () {

		transform.DOMove (Vector3.one, 2f);
		
	}

}

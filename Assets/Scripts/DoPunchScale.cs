using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoPunchScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOPunchScale (Vector3.one * 2, 2f);
	}

}

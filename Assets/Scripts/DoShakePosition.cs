using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoShakePosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOShakePosition (1f);
	}
}

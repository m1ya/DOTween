using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class settingTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOMove (Vector3.one * 3, 2f).SetEase (Ease.InOutQuart).SetLoops (3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

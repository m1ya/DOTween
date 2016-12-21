using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoPath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3[] paths = new Vector3[] {
			Vector3.one * 3,
			Vector3.right * 2,
			Vector3.up * 5,
			Vector3.left * 3,
			Vector3.down * 2
		};

		transform.DOPath (paths, 5f, PathType.Linear);
	}

}

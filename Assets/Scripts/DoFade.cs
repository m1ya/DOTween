using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoFade : MonoBehaviour {

	public Image image;

	// Use this for initialization
	void Start () {
		image.DOFade (0, 2f);
	}
	
}

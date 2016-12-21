using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DofillAmount : MonoBehaviour {

	public Image image;

	// Use this for initialization
	void Start () {
		image.DOFillAmount (0, 2);
	}
	

}

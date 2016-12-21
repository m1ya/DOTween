using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTween : MonoBehaviour {

	public Text text;
	private int val;

	public int Val {
		set {
			val = value;
			text.text = val.ToString ();
		}
		get {
			return val;
		}
	}

	void Start ()
	{
		DOTween.To (() => Val, x => Val = x, 100, 4f);
	}
}

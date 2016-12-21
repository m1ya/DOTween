using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour {

	Vector3 startPos;
	Vector3 endPos;
	float moveTime = 1f;
	float startTime;
	float time;
	float rate;
	bool moveFlag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			endPos = new Vector3 (Random.Range(5,-5), 0, Random.Range(5,-5));
			startTime = Time.timeSinceLevelLoad;
			startPos = this.transform.position;
		}
			
			time = Time.timeSinceLevelLoad - startTime;
			rate = time / moveTime;
			transform.position = Vector3.Lerp (startPos, endPos, rate);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour {

	public GameObject obj;
	Vector3 rotateStep;

//	public SwipeManager sm;

	// Use this for initialization
	void Start () {
		rotateStep = new Vector3 (0f, 0f, 15f);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (SwipeManager.IsSwiping ());
		if (SwipeManager.IsSwiping ()) {
			// rotate the object
			obj.transform.Rotate (rotateStep);
		}
	}
}

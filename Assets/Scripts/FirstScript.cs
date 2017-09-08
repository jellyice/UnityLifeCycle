using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour {
	private bool isUpdateLogShowed = false;

	public FirstScript() {
		Debug.Log("FirstScript constructor");
	}

	~FirstScript() {
		Debug.Log("FirstScript destructor");
	}

	void Awake() {
		Debug.Log(name + " Awake");
	}

	void OnEnable() {
		Debug.Log(name + " OnEnable");
	}

	void OnDisable() {
		Debug.Log(name + " OnDisable");
	}

	void Start() {
		Debug.Log(name + " Start");
	}
	
	void Update() {
		if (isUpdateLogShowed == false) {
			Debug.Log(name + " Update");
			isUpdateLogShowed = true;
		}
	}

	void OnDestroy() {
		Debug.Log(name + " OnDestroy");
	}
}

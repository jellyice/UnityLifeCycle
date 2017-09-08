using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inactive : MonoBehaviour, Observer {
	private bool isUpdateLogShowed = false;

	public Inactive() {
		Debug.Log("Inactive constructor");
	}

	~Inactive() {
		Debug.Log("Inactive destructor");
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

	public void notify() {
		Debug.Log(name + " notify");
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScript : MonoBehaviour {
	private bool isUpdateLogShowed = false;

	public NormalScript() {
		Debug.Log("NormalScript constructor");
	}

	~NormalScript() {
		Debug.Log("NormalScript destructor");
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

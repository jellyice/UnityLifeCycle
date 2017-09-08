using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activate : MonoBehaviour {
	public Button actBtn;
	public Image target;
	public Inactive targetScript;

	bool isUpdateLogShowed = false;
	Observer targetOb;

	public Activate() {
		Debug.Log("Activate constructor");
	}

	~Activate() {
		Debug.Log("Activate destructor");
	}

	void Awake() {
		Debug.Log(name + " Awake");
		actBtn.onClick.AddListener(actBtnClick);
		targetOb = targetScript as Observer;
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

	void actBtnClick() {
		targetOb.notify();
		target.gameObject.SetActive(true);
		targetOb.notify();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddShaker : MonoBehaviour {

public ParticleSystem system;
	// Use this for initialization
	public void AddShake(GameObject gObj) {
		gObj.AddComponent(typeof(Shaker));
	}
	public void StartWater() {
		system.Play();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {
	private Light light;
	private MeshRenderer mesh;
	public float rate = 2;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light>();
		mesh = light.GetComponentInParent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range(1,200) <= rate) {
			light.enabled = !light.enabled;
			mesh.enabled = !mesh.enabled;
		}
	}
}

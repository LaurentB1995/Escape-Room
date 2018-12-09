using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungCutter : MonoBehaviour {
	public GameObject LungPrefab;
	private AudioSource source;
	void Start() {
		source = this.GetComponent<AudioSource>();
	}

	// Use this for initialization
	void OnTriggerEnter(Collider collider) {
		
		if (collider.gameObject.tag == "Lungs") {
			var lung1 = GameObject.Instantiate<GameObject>(LungPrefab);
		var lung2 = GameObject.Instantiate<GameObject>(LungPrefab);
		lung1.transform.position = collider.gameObject.transform.position;// - Vector3.right * 2;
		lung2.transform.position = collider.gameObject.transform.position;// + Vector3.right * 2;
		Destroy(collider.gameObject);
		source.Play();
		}
	}
}

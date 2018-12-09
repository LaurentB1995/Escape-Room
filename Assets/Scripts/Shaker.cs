using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour {
	public float startShakeForce = 0.01f;
	public float timeToExplode = 3;
	public ParticleSystem particles;
	private Vector3 startpos;

	// Use this for initialization
	void Start () {
		startpos = transform.position;
		particles.Play();
	}
	
	// Update is called once per frame
	void Update () {
		timeToExplode -= Time.deltaTime;
		if (timeToExplode <= 0) {
			
			Destroy(this.gameObject);
		}
		

		startpos = transform.position;
		transform.position = startpos + Vector3.up * Random.Range(startShakeForce * -1, startShakeForce) + Vector3.right * Random.Range(startShakeForce * -1, startShakeForce);
	}
}

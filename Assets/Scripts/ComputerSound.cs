using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerSound : MonoBehaviour {
	private AudioSource source;
	public float distance = 1;
	public GameObject player;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	
	public void PlaySound() {
		if (Vector3.Distance(transform.position,player.transform.position) < distance) {
			source.Play();
		}
	}
	
}

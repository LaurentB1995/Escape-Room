using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {
public float speed = 1.6f;
private Vector3 pos;
private Vector3 beginpos;
	// Use this for initialization
	void Start () {
		pos = new Vector3(transform.position.x,transform.position.y,2.1f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position,pos,speed*Time.deltaTime);
	}
}

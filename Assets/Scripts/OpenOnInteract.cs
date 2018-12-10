using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOnInteract : MonoBehaviour {
	
	private bool isOpen = false;
	private float endPos;
	// Use this for initialization
	void Start () {
		endPos = transform.position.z + 0.58f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z <= endPos) {
			transform.localPosition = Vector3.Lerp(transform.localPosition,new Vector3(Mathf.Clamp(transform.localPosition.x - 0.58f,-0.3f,0.3f),transform.localPosition.y,transform.localPosition.z),0.5f*Time.deltaTime);
		}		
	}

}

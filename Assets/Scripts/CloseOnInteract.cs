using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOnInteract : MonoBehaviour {
    private Vector3 endPos;

    void Start() {
        endPos = new Vector3(transform.position.x,transform.position.y,transform.position.z - 0.58f);
    }
    void Update() {
        transform.localPosition = Vector3.Lerp(transform.localPosition,new Vector3(Mathf.Clamp(transform.localPosition.x + 0.58f,-0.3f,0.3f),transform.localPosition.y,transform.localPosition.z),Time.deltaTime * 0.5f);
    }

}
	
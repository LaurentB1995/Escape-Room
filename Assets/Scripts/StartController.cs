using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour {
	public GameObject leftDoor;

	// Use this for initialization
	public void OpenStartDoors() {
		leftDoor.transform.rotation = Quaternion.Lerp(leftDoor.transform.rotation,new Quaternion(leftDoor.transform.rotation.x,90f,leftDoor.transform.rotation.z,leftDoor.transform.rotation.w),0.01f);
		SceneManager.LoadScene(1);
	}
}

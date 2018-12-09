using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class KeyController : MonoBehaviour
{

    public Collider Key;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Golden Key")
        {
			if(col.gameObject.GetComponent(typeof(Throwable)) == null)
            col.gameObject.AddComponent(typeof(Throwable));

			if(col.gameObject.GetComponent(typeof(Interactable)) == null)
            col.gameObject.AddComponent(typeof(Interactable));

			if(col.gameObject.GetComponent(typeof(VelocityEstimator)) == null)
            col.gameObject.AddComponent(typeof(VelocityEstimator));

			Debug.Log("Added COmponents");
			Destroy(this);
        }
    }
}

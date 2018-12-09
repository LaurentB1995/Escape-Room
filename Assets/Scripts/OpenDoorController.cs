using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class OpenDoorController : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
        //OpenDoor();
    }

    public void OpenDoor()
    {
        //source.pitch = Random.Range(.9f, 1.1f);
        source.PlayOneShot(source.clip);
        Animator anim = gameObject.GetComponentInParent<Animator>();
        anim.SetTrigger("Open");
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Golden Key")
        {
            OpenDoor();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScriptManager: MonoBehaviour
{
    public float distance = 4f;
    public GameObject player;
    public void AddOpenDoorScript(GameObject door) {
        var dist = Vector3.Distance(player.transform.position,door.transform.position);
        if (dist < distance) {
            if (door.GetComponent<OpenOnInteract>() == null) {
                if (door.GetComponent<CloseOnInteract>() != null) {
                    Destroy(door.GetComponent<CloseOnInteract>());
                }
                door.AddComponent<OpenOnInteract>();
            } else {
                Destroy(door.GetComponent<OpenOnInteract>());
                door.AddComponent<CloseOnInteract>();
            }
            
        }  
        
    }

}
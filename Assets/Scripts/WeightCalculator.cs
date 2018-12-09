using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCalculator : MonoBehaviour
{

    public GameObject Arrow;
    public Dictionary<String, float> OrganWeightMap;
    private float totalWeight;
    public GameObject Door;

    public AudioSource source;
	public AudioClip clip;

    void Start()
    {
        OrganWeightMap = new Dictionary<string, float>();
        OrganWeightMap.Add("Lung", 60); //1kg
        OrganWeightMap.Add("Lungs",120);
        OrganWeightMap.Add("Brain", 120); //2kg
        OrganWeightMap.Add("Liver", 15); //250g
        OrganWeightMap.Add("OtherOrgan", 24); //400g
        totalWeight = 0;
		//OpenDoor ();
    }
    public void OnTriggerEnter(Collider collider)
    {
        var value = OrganWeightMap[collider.gameObject.tag];
        try
        {
            Move(value);
            totalWeight += value;
            CheckTotalWeight();
            Debug.Log(totalWeight + " tag:" + collider.gameObject.tag);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        var value = OrganWeightMap[collider.gameObject.tag] * -1;
        try
        {
            Move(value);
            totalWeight += value;
            CheckTotalWeight();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void CheckTotalWeight()
    {
        if (totalWeight == 243)
        {
			OpenDoor ();
        }
    }

    private void Move(float v)
    {
        Vector3 old = Arrow.transform.eulerAngles;

        Arrow.transform.eulerAngles = old + new Vector3(0, 0, v);
    }

	void OpenDoor(){
        Door.AddComponent(typeof(DoorOpener));
		Debug.Log ("Playing Sliding Sound");
        source = Door.GetComponent<AudioSource>();
        
		source.PlayOneShot (clip);
       
	}
}

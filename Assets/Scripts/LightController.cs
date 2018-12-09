using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public GameObject[] LightsToTurnOff;
    public GameObject Board;
    public AudioClip lightOffSound;
    public AudioClip lightOnSound;

    private bool lightsOn = true;
    private AudioSource source;

    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    public void SwitchLights()
    {
        if (lightsOn)
        {
            source.PlayOneShot(lightOffSound);
        }
        else
        {
            source.PlayOneShot(lightOnSound);
        }

        foreach (GameObject light in LightsToTurnOff)
        {
            light.SetActive(!light.activeSelf);
        }
        Board.SetActive(!Board.activeSelf);

		lightsOn = !lightsOn;
    }
}

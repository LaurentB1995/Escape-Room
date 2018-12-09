using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeypadController : MonoBehaviour
{
    public string combination = "1234";
    public Animator doorLeft;
    public Animator doorRight;
    public Text Display;

    private AudioSource source;
    private string currentCombination = "";
    private SoundController endSound;

    void Start()
    {
        //OpenDoors ();
        source = gameObject.GetComponent<AudioSource>();
        endSound = gameObject.GetComponent<SoundController>();
    }

    public void BtnPressed(string btnText)
    {
        PlaySound();
        currentCombination += btnText;
        DisplayText();
    }

    public void BtnCPressed()
    {
        PlaySound();
        currentCombination = "";
        Debug.Log(currentCombination);
        DisplayText();
    }

    public void BtnEPressed()
    {
        PlaySound();

        if (currentCombination.Equals(combination))
        {
            OpenDoors();
            Debug.Log("Thanks for PLaying!");
            StartCoroutine(EndGame());
        }

        else
        {
            currentCombination = "WRONG";
            Debug.Log(currentCombination);
            DisplayText();
        }
    }

    private void DisplayText()
    {
        Display.text = currentCombination;
    }

    public void OpenDoors()
    {
        doorLeft.SetTrigger("Open");
        doorRight.SetTrigger("Open");
    }

    public void PlaySound()
    {
        source.PlayOneShot(source.clip);
    }

    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2);
        endSound.PlayAudio();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}

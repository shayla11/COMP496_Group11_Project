using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


//Author: Shayla Sexton

public class keypad : MonoBehaviour
{

    public string password = "1891";
    public bool correct_answer_inputed = false;
    private string userInput = "";

    public Light red_light;
    public Light green_light;
    public GameObject sliding_door;

    public TextMeshPro KeypadNumberDisplay;

    public AudioClip clickSound;
    public AudioClip openSound;
    public AudioClip wrongSound;
    AudioSource audioSource;

    private void Start() {
        userInput = "";
        audioSource = GetComponent<AudioSource>();
        KeypadNumberDisplay.text = ("");

        red_light.enabled = true;
        red_light.intensity = 0;
        green_light.enabled = true;
        green_light.intensity = 0;

        sliding_door.GetComponent<Animator>().enabled = false;

    }

    public void ButtonClicked(string number){
        if (!correct_answer_inputed){
            audioSource.PlayOneShot(clickSound);
            KeypadNumberDisplay.text += number + " ";
            red_light.intensity = 0;
            green_light.intensity = 0;



            userInput += number;
            if (userInput.Length == 4){
                //check password
                if (userInput == password){
                    Debug.Log("Entry Allowed");
                    green_light.intensity = 3;
                    audioSource.PlayOneShot(openSound);
                    userInput = "";
                    correct_answer_inputed = true;
                    //Start animation
                    sliding_door.GetComponent<Animator>().enabled = true; 


                } else {
                    Debug.Log("Not this time");
                    red_light.intensity = 3;
                    audioSource.PlayOneShot(wrongSound);
                    userInput = "";
                    KeypadNumberDisplay.text = "";

                }
            }
        } 
        
    }
}

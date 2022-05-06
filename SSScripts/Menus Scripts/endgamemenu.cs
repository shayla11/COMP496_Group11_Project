using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//Author: Shayla Sexton

public class endgamemenu : MonoBehaviour
{

    public GameObject Relic_1;
    public GameObject Relic_2;
    public GameObject Relic_3;
    public GameObject crosshair;

    public GameObject winscreen;
    public AudioClip pickupsound;
    AudioSource audioSource;

    public GameObject textBackground;
    public TextMeshProUGUI itemDescription;


    void Start()
    {
        GameObject Relic_1 = GameObject.Find("Relic_1");
        GameObject Relic_2 = GameObject.Find("Relic_2");
        GameObject Relic_3 = GameObject.Find("Relic_3");
        audioSource = GetComponent<AudioSource>();

        winscreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        pickUp_Relic_1 Relic_1_PickUp_Script = Relic_1.GetComponent<pickUp_Relic_1>();
        pickUp_Relic_2 Relic_2_PickUp_Script = Relic_2.GetComponent<pickUp_Relic_2>();
        pickUp_Relic_3 Relic_3_PickUp_Script = Relic_3.GetComponent<pickUp_Relic_3>();

        //Once the player has collected all 3 relics, commense "end game sequence"
        
        if(Relic_1_PickUp_Script.obtain_relic_1 & Relic_2_PickUp_Script.obtain_relic_2 & Relic_3_PickUp_Script.obtain_relic_3){
            //itemDescription.text = ("You've found all Three Relics \n YOU CAN ESCAPE!");
            //Play some fan fair music, and fade to black
            //Maybe confetti gif covers screen or soemthing
            audioSource.PlayOneShot(pickupsound);

            winscreen.SetActive(true);
            audioSource.PlayOneShot(pickupsound);
            enabled = false;




            }


        
    }

    public void GoToMainMenu(){
        SceneManager.LoadScene("Main Menu"); 

    }

}

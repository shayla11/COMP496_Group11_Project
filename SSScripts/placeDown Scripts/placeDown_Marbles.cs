using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton

public class placeDown_Marbles : MonoBehaviour
{
        public Transform final_Marble_1_Dest;
        public Transform final_Marble_2_Dest;
        public Transform final_Marble_3_Dest;

        public AudioClip pickupsound;
        AudioSource audioSource;

        //ImagesButtons
        public GameObject Marble_1_Img;
        public GameObject Marble_2_Img;
        public GameObject Marble_3_Img;
        public GameObject Marble_Clue_Img;

        //Clue
        public GameObject Marble_Clue;
        public GameObject Marble_Clue_Decoy;

    // Start is called before the first frame update
    void Start()
    {
        Marble_Clue_Decoy.GetComponent<Animator>().enabled = false;
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        GameObject Marble_1 = GameObject.Find("Marble_1");
        pickUp_Marble_1 Marble_1_PickUp_Script = Marble_1.GetComponent<pickUp_Marble_1>();

        GameObject Marble_2 = GameObject.Find("Marble_2");
        pickUp_Marble_2 Marble_2_PickUp_Script = Marble_2.GetComponent<pickUp_Marble_2>();

        GameObject Marble_3 = GameObject.Find("Marble_3");
        pickUp_Marble_3 Marble_3_PickUp_Script = Marble_3.GetComponent<pickUp_Marble_3>();

        pickUp_Marble_Clue Marble_Clue_PickUp_Script = Marble_Clue.GetComponent<pickUp_Marble_Clue>();

        //If all the marblels have been placed on the podium, then release the next clue
        if (Marble_1_PickUp_Script.finalpos_Marble_1 & Marble_2_PickUp_Script.finalpos_Marble_2 & Marble_3_PickUp_Script.finalpos_Marble_3){
            Marble_Clue_Decoy.GetComponent<Animator>().enabled = true; 
            Marble_Clue_PickUp_Script.Marble_Puzzle_Completed = true;
            audioSource.PlayOneShot(pickupsound);
            enabled = false;

        }

    }

    void OnMouseDown() {
        //Change based on what object is being held
        //Or maybe have a different script for each item where an item can be placed
        GameObject Marble_1 = GameObject.Find("Marble_1");
        pickUp_Marble_1 Marble_1_PickUp_Script = Marble_1.GetComponent<pickUp_Marble_1>();

        GameObject Marble_2 = GameObject.Find("Marble_2");
        pickUp_Marble_2 Marble_2_PickUp_Script = Marble_2.GetComponent<pickUp_Marble_2>();

        GameObject Marble_3 = GameObject.Find("Marble_3");
        pickUp_Marble_3 Marble_3_PickUp_Script = Marble_3.GetComponent<pickUp_Marble_3>();

        if (Marble_1_PickUp_Script.holding_Marble_1){
            Marble_1.GetComponent<Rigidbody>().useGravity = false;
            Marble_1.transform.position = final_Marble_1_Dest.position;
            Marble_1.transform.parent = GameObject.Find("FinalMarble1Dest").transform;
            Marble_1_PickUp_Script.holding_Marble_1 = false;
            Marble_1_PickUp_Script.finalpos_Marble_1 = true;
            Marble_1_Img.SetActive(false);


        } if (Marble_2_PickUp_Script.holding_Marble_2){
            Marble_2.GetComponent<Rigidbody>().useGravity = false;
            Marble_2.transform.position = final_Marble_2_Dest.position;
            Marble_2.transform.parent = GameObject.Find("FinalMarble2Dest").transform;
            Marble_2_PickUp_Script.holding_Marble_2 = false;
            Marble_2_PickUp_Script.finalpos_Marble_2 = true;
            Marble_2_Img.SetActive(false);


        } if (Marble_3_PickUp_Script.holding_Marble_3){
            Marble_3.GetComponent<Rigidbody>().useGravity = false;
            Marble_3.transform.position = final_Marble_3_Dest.position;
            Marble_3.transform.parent = GameObject.Find("FinalMarble3Dest").transform;
            Marble_3_PickUp_Script.holding_Marble_3 = false;
            Marble_3_PickUp_Script.finalpos_Marble_3 = true;
            Marble_3_Img.SetActive(false);

        }


    }
}

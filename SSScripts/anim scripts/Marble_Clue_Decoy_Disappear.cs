using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class Marble_Clue_Decoy_Disappear : MonoBehaviour
{

    //Marble
    public GameObject Marble_Clue;
    public GameObject Marble_Clue_Decoy;

    void Start(){}

    void Update(){}

     void OnMouseDown() 
    {
        pickUp_Marble_Clue Marble_Clue_PickUp_Script = Marble_Clue.GetComponent<pickUp_Marble_Clue>();

        if (Marble_Clue_PickUp_Script.Marble_Puzzle_Completed){
            Marble_Clue.SetActive(true);
            Marble_Clue_Decoy.SetActive(false);
            Marble_Clue_Decoy.GetComponent<Animator>().enabled = false; 

           
        }
    }
}


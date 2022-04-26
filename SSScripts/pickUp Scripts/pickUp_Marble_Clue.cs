using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton


public class pickUp_Marble_Clue : MonoBehaviour
{
    public Transform theDest;
    public Transform handDest;
    public TextMeshProUGUI itemDescription;
    public GameObject backpackButton;
    public GameObject putbackButton;
    public GameObject textBackground;
    public Vector3 itemOPosition;
    public Transform parentOPosition;
    public GameObject Inventory;

    //Marble
    public GameObject Marble_Clue;
    public GameObject Marble_Clue_Decoy;
    public bool holding_Marble_Clue; //may not need this
    public bool viewing_Marble_Clue;
    public bool finalpos_Marble_Clue; //may not need this
    public bool Marble_Puzzle_Completed;

    //May need to develop alternative viewing for paper clues instead of holding them

    void Start(){
        holding_Marble_Clue = false;
        viewing_Marble_Clue = false;
        finalpos_Marble_Clue = false;
        Marble_Puzzle_Completed = false;
        Marble_Clue.SetActive(false);
        backpackButton.SetActive(false);
        putbackButton.SetActive(false);
        textBackground.SetActive(false);

    }

    void Update(){

    }
    
    void OnMouseDown() 
    {
        if (Marble_Puzzle_Completed){
            //Marble_Clue.SetActive(true);
            //Marble_Clue_Decoy.SetActive(false);
            //Marble_Clue_Decoy.GetComponent<Animator>().enabled = false; 

            //Player Movement is Restricted
            GameObject thePlayer = GameObject.Find("Player");
            GameObject theCamera = GameObject.Find("First Person Camera");

            playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
            mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
        
            playerScript.canMoveWASD = false;
            mouseScript.canMoveMouse = false;

            //Show Buttons
            backpackButton.SetActive(true);
            putbackButton.SetActive(true);
            textBackground.SetActive(true);
            
            


            Cursor.lockState = CursorLockMode.None;

            //Will need to change to be object specific
            itemOPosition = Marble_Clue.transform.position;
            parentOPosition = Marble_Clue.transform.parent;
            Marble_Clue.transform.position = theDest.position;
            Marble_Clue.transform.parent = GameObject.Find("ItemDestination").transform;
            itemDescription.text = ("You've found a Clue! \n This looks like a code to a Ceasar Cipher, maybe I can use this somehwere else in the museum!");
            viewing_Marble_Clue = true;
        }
    }

        public void HoldItem(){

        //Transform to new "hand" location
        Marble_Clue.transform.position = handDest.position;
        Marble_Clue.transform.parent = GameObject.Find("HandDestination").transform;
        Marble_Clue.SetActive(true);
        holding_Marble_Clue = true;


        //Player Resumes Movement
        GameObject thePlayer = GameObject.Find("Player");
        GameObject theCamera = GameObject.Find("First Person Camera");
        playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
        mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
        playerScript.canMoveWASD = true;
        mouseScript.canMoveMouse = true;

        //Close Inventory
        Inventory.SetActive(false);
        
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_DarkBlue_Crane : MonoBehaviour
{
    public Transform theDest;
    public Transform handDest;
    public TextMeshProUGUI itemDescription;
    public GameObject textBackground;
    public GameObject backpackButton;
    public GameObject putbackButton;
    public Vector3 itemOPosition;
    public Transform parentOPosition;
    public GameObject Inventory;

    public AudioClip pickupsound;
    AudioSource audioSource;

    //Marble
    public GameObject dBlue_Crane;
    public bool holding_dBlue_Crane;
    public bool viewing_dBlue_Crane;
    public bool finalpos_dBlue_Crane;
    //public Color startcolor;


    void Start(){
        holding_dBlue_Crane = false;
        viewing_dBlue_Crane = false;
        finalpos_dBlue_Crane = false;
        audioSource = GetComponent<AudioSource>();

    }
    
     void OnMouseDown() 
    {
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

        itemOPosition = dBlue_Crane.transform.position;
        parentOPosition = dBlue_Crane.transform.parent;
        dBlue_Crane.transform.position = theDest.position;
        dBlue_Crane.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Dark Blue Baby Crane!\n I wonder where its mom is..");
        viewing_dBlue_Crane = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        dBlue_Crane.transform.position = handDest.position;
        dBlue_Crane.transform.parent = GameObject.Find("HandDestination").transform;
        dBlue_Crane.SetActive(true);
        holding_dBlue_Crane = true;


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
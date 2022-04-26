using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton


public class pickUp_Red_Crane : MonoBehaviour
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
    public GameObject Red_Crane;
    public bool holding_Red_Crane;
    public bool viewing_Red_Crane;
    public bool finalpos_Red_Crane;
    //public Color startcolor;


    void Start(){
        holding_Red_Crane = false;
        viewing_Red_Crane = false;
        finalpos_Red_Crane = false;
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

        itemOPosition = Red_Crane.transform.position;
        parentOPosition = Red_Crane.transform.parent;
        Red_Crane.transform.position = theDest.position;
        Red_Crane.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Red Baby Crane!\n I wonder where its mom is..");
        viewing_Red_Crane = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Red_Crane.transform.position = handDest.position;
        Red_Crane.transform.parent = GameObject.Find("HandDestination").transform;
        Red_Crane.SetActive(true);
        holding_Red_Crane = true;


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

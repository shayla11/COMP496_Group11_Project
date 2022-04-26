using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Purple_Crane : MonoBehaviour
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
    public GameObject Purple_Crane;
    public bool holding_Purple_Crane;
    public bool viewing_Purple_Crane;
    public bool finalpos_Purple_Crane;
    //public Color startcolor;


    void Start(){
        holding_Purple_Crane = false;
        viewing_Purple_Crane = false;
        finalpos_Purple_Crane = false;
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

        itemOPosition = Purple_Crane.transform.position;
        parentOPosition = Purple_Crane.transform.parent;
        Purple_Crane.transform.position = theDest.position;
        Purple_Crane.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Purple Baby Crane!\n Maybe I should return it to its brothers and sisters..");
        viewing_Purple_Crane = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Purple_Crane.transform.position = handDest.position;
        Purple_Crane.transform.parent = GameObject.Find("HandDestination").transform;
        Purple_Crane.SetActive(true);
        holding_Purple_Crane = true;


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
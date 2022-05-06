using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton


public class pickUp_Battery : MonoBehaviour
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

    public AudioClip placedownsound;
    AudioSource audioSource;

    //Marble
    public GameObject Battery;
    public bool holding_Battery;
    public bool viewing_Battery;
    public bool finalpos_Battery;

    void Start(){
        holding_Battery = false;
        viewing_Battery = false;
        finalpos_Battery = false;
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

        //Will need to change to be object specific
        //GetComponent<Rigidbody>().useGravity = false;
        itemOPosition = Battery.transform.position;
        parentOPosition = Battery.transform.parent;
        Battery.transform.position = theDest.position;
        Battery.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Battery!\n Maybe I can use this to turn something on");
        viewing_Battery = true;
        audioSource.PlayOneShot(placedownsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Battery.transform.position = handDest.position;
        Battery.transform.parent = GameObject.Find("HandDestination").transform;
        Battery.SetActive(true);
        holding_Battery = true;


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


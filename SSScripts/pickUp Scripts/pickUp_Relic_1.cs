using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Relic_1 : MonoBehaviour
{
    public Transform theDest;
    public Transform handDest;
    public Transform hideDest;
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
    public GameObject Relic_1;
    public bool holding_Relic_1;
    public bool viewing_Relic_1;
    public bool finalpos_Relic_1;
    public bool obtain_relic_1;


    void Start(){
        holding_Relic_1 = false;
        viewing_Relic_1 = false;
        finalpos_Relic_1 = false;
        obtain_relic_1 = false;
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
        itemOPosition = Relic_1.transform.position;
        parentOPosition = Relic_1.transform.parent;
        Relic_1.transform.position = theDest.position;
        Relic_1.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Relic! \n Nice!");
        viewing_Relic_1 = true;
        obtain_relic_1 = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Relic_1.transform.position = handDest.position;
        Relic_1.transform.parent = GameObject.Find("HandDestination").transform;
        Relic_1.SetActive(true);
        holding_Relic_1 = true;


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
    
    //Put in seperate file
    /*
    public void EmptyHand(){

        //Transform to new "hand" location
        Relic_1.transform.position = hideDest.position;
        //Relic_1.transform.parent = GameObject.Find("HideObjectsDestination").transform;
        //Relic_1.SetActive(true);
        holding_Relic_1 = false;


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
    */


}

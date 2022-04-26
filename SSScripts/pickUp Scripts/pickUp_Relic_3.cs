using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Relic_3 : MonoBehaviour
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
    public GameObject Relic_3;
    public bool holding_Relic_3;
    public bool viewing_Relic_3;
    public bool finalpos_Relic_3;
    public bool obtain_relic_3;


    void Start(){
        holding_Relic_3 = false;
        viewing_Relic_3 = false;
        finalpos_Relic_3 = false;
        obtain_relic_3 = false;
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
        itemOPosition = Relic_3.transform.position;
        parentOPosition = Relic_3.transform.parent;
        Relic_3.transform.position = theDest.position;
        Relic_3.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Relic! \n Nice!");
        viewing_Relic_3 = true;
        obtain_relic_3 = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Relic_3.transform.position = handDest.position;
        Relic_3.transform.parent = GameObject.Find("HandDestination").transform;
        Relic_3.SetActive(true);
        holding_Relic_3 = true;


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
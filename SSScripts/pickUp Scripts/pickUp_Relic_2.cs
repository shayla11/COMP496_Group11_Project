using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Relic_2 : MonoBehaviour
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

    //Marble
    public GameObject Relic_2;
    public bool holding_Relic_2;
    public bool viewing_Relic_2;
    public bool finalpos_Relic_2;
    public bool obtain_relic_2;


    void Start(){
        holding_Relic_2 = false;
        viewing_Relic_2 = false;
        finalpos_Relic_2 = false;
        obtain_relic_2 = false;

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
        itemOPosition = Relic_2.transform.position;
        parentOPosition = Relic_2.transform.parent;
        Relic_2.transform.position = theDest.position;
        Relic_2.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Relic! \n Nice!");
        viewing_Relic_2 = true;
        obtain_relic_2 = true;
    }

        public void HoldItem(){

        //Transform to new "hand" location
        Relic_2.transform.position = handDest.position;
        Relic_2.transform.parent = GameObject.Find("HandDestination").transform;
        Relic_2.SetActive(true);
        holding_Relic_2 = true;


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
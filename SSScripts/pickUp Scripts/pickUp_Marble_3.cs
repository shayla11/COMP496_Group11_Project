using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickUp_Marble_3 : MonoBehaviour
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

    //Marble
    public GameObject Marble_3;
    public bool holding_Marble_3;
    public bool viewing_Marble_3;
    public bool finalpos_Marble_3;


    void Start(){
        holding_Marble_3 = false;
        viewing_Marble_3 = false;
        finalpos_Marble_3 = false;

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
        itemOPosition = Marble_3.transform.position;
        parentOPosition = Marble_3.transform.parent;
        Marble_3.transform.position = theDest.position;
        Marble_3.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Green Marble! \n I wonder where this goes..");
        viewing_Marble_3 = true;
    }

        public void HoldItem(){

        //Transform to new "hand" location
        Marble_3.transform.position = handDest.position;
        Marble_3.transform.parent = GameObject.Find("HandDestination").transform;
        Marble_3.SetActive(true);
        holding_Marble_3 = true;


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


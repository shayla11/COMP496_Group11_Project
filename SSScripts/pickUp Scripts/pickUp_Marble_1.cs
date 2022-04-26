using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Marble_1 : MonoBehaviour
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
    public GameObject Marble_1;
    public bool holding_Marble_1;
    public bool viewing_Marble_1;
    public bool finalpos_Marble_1;
    //public Color startcolor;


    void Start(){
        holding_Marble_1 = false;
        viewing_Marble_1 = false;
        finalpos_Marble_1 = false;
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
        itemOPosition = Marble_1.transform.position;
        parentOPosition = Marble_1.transform.parent;
        Marble_1.transform.position = theDest.position;
        Marble_1.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Yellow Marble!\n I wonder where this goes..");
        viewing_Marble_1 = true;
    }

        public void HoldItem(){

        //Transform to new "hand" location
        Marble_1.transform.position = handDest.position;
        Marble_1.transform.parent = GameObject.Find("HandDestination").transform;
        Marble_1.SetActive(true);
        holding_Marble_1 = true;


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

    /**
    void OnMouseEnter() {
        if (!viewing_Marble_1 && !holding_Marble_1 && !finalpos_Marble_1){
            startcolor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.white;
        }


    }
    void OnMouseExit(){
        if (!viewing_Marble_1 && !holding_Marble_1 && !finalpos_Marble_1){
            GetComponent<Renderer>().material.color = startcolor;
        }
    }
    **/

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickUp_Marble_2 : MonoBehaviour
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
    public GameObject Marble_2;
    public bool holding_Marble_2;
    public bool viewing_Marble_2;
    public bool finalpos_Marble_2;


    void Start(){
        holding_Marble_2 = false;
        viewing_Marble_2 = false;
        finalpos_Marble_2 = false;
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
        itemOPosition = Marble_2.transform.position;
        parentOPosition = Marble_2.transform.parent;
        Marble_2.transform.position = theDest.position;
        Marble_2.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Orange Marble! \n I wonder where this goes..");
        viewing_Marble_2 = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Marble_2.transform.position = handDest.position;
        Marble_2.transform.parent = GameObject.Find("HandDestination").transform;
        Marble_2.SetActive(true);
        holding_Marble_2 = true;


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

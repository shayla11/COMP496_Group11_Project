using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Pink_Crane : MonoBehaviour
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
    public GameObject Pink_Crane;
    public bool holding_Pink_Crane;
    public bool viewing_Pink_Crane;
    public bool finalpos_Pink_Crane;
    //public Color startcolor;


    void Start(){
        holding_Pink_Crane = false;
        viewing_Pink_Crane = false;
        finalpos_Pink_Crane = false;
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

        itemOPosition = Pink_Crane.transform.position;
        parentOPosition = Pink_Crane.transform.parent;
        Pink_Crane.transform.position = theDest.position;
        Pink_Crane.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Pink Baby Crane!\n Maybe I should return it to its brothers and sisters..");
        viewing_Pink_Crane = true;
        audioSource.PlayOneShot(pickupsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Pink_Crane.transform.position = handDest.position;
        Pink_Crane.transform.parent = GameObject.Find("HandDestination").transform;
        Pink_Crane.SetActive(true);
        holding_Pink_Crane = true;


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
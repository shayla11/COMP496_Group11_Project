using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Author: Shayla Sexton

public class pickUp_Bone : MonoBehaviour
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
    public GameObject Bone;
    public bool holding_Bone;
    public bool viewing_Bone;
    public bool finalpos_Bone;

    void Start(){
        holding_Bone = false;
        viewing_Bone = false;
        finalpos_Bone = false;
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
        itemOPosition = Bone.transform.position;
        parentOPosition = Bone.transform.parent;
        Bone.transform.position = theDest.position;
        Bone.transform.parent = GameObject.Find("ItemDestination").transform;
        itemDescription.text = ("You've found a Bone!\n Maybe a golden dog deserves a golden treat!");
        viewing_Bone = true;
        audioSource.PlayOneShot(placedownsound);

    }

        public void HoldItem(){

        //Transform to new "hand" location
        Bone.transform.position = handDest.position;
        Bone.transform.parent = GameObject.Find("HandDestination").transform;
        Bone.SetActive(true);
        holding_Bone = true;


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

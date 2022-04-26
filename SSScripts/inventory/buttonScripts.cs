using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


//Author: Shayla Sexton

public class buttonScripts : MonoBehaviour
{
    public TextMeshProUGUI itemDescription;
    public GameObject textBackground;
    public GameObject backpackButton;
    public GameObject putbackButton;
    private SpriteRenderer spriteRenderer; 
    public Transform handDest;
    public Transform hideDest;
    public GameObject Inventory;

    //Items
    public GameObject Marble_1;
    public GameObject Marble_2;
    public GameObject Marble_3;
    public GameObject Marble_Clue;
    public GameObject Relic_1;
    public GameObject Battery;
    public GameObject Bone;
    public GameObject Relic_2;




    //ImagesButtons
    public GameObject Marble_1_Img;
    public GameObject Marble_2_Img;
    public GameObject Marble_3_Img;
    public GameObject Marble_Clue_Img;
    public GameObject Relic_1_Img;
    public GameObject Battery_Img;
    public GameObject Bone_Img;
    public GameObject Relic_2_Img;



    public void Start(){
        Marble_1_Img.SetActive(false);
        Marble_2_Img.SetActive(false);
        Marble_3_Img.SetActive(false);
        Marble_Clue_Img.SetActive(false);
        Relic_1_Img.SetActive(false);
        Battery_Img.SetActive(false);
        Bone_Img.SetActive(false);
        Relic_2_Img.SetActive(false);




        GameObject Marble_1 = GameObject.Find("Marble_1");    
        GameObject Marble_2 = GameObject.Find("Marble_2");
        GameObject Marble_3 = GameObject.Find("Marble_3");
        GameObject Marble_Clue = GameObject.Find("MarbleClue");
        GameObject Relic_1 = GameObject.Find("Relic_1");
        GameObject Battery = GameObject.Find("Battery");
        GameObject Bone = GameObject.Find("Bone");
        GameObject Relic_2 = GameObject.Find("Relic_2");



    }

    public void AddItemToInventory()
    {

        hideObjectUpdateInventory();

        //Player Resumes Movement
        GameObject thePlayer = GameObject.Find("Player");
        GameObject theCamera = GameObject.Find("First Person Camera");
        playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
        mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
        playerScript.canMoveWASD = true;
        mouseScript.canMoveMouse = true;

        //Hide Buttons
        backpackButton.SetActive(false);
        putbackButton.SetActive(false);
        textBackground.SetActive(false);


        //Reset Prompt Window
        itemDescription.text = ("");

    }

    public void putBackItem()
    {
        putBackSpecificItem();

        //Player Resumes Movement
        GameObject thePlayer = GameObject.Find("Player");
        GameObject theCamera = GameObject.Find("First Person Camera");
        playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
        mouseLook mouseScript = theCamera.GetComponent<mouseLook>();

        playerScript.canMoveWASD = true;
        mouseScript.canMoveMouse = true;

        //Hide Buttons
        backpackButton.SetActive(false);
        putbackButton.SetActive(false);
        textBackground.SetActive(false);


        //Reset Prompt Window
        itemDescription.text = ("");

    }

    public void hideObjectUpdateInventory(){

        pickUp_Marble_1 Marble_1_PickUp_Script = Marble_1.GetComponent<pickUp_Marble_1>();
        pickUp_Marble_2 Marble_2_PickUp_Script = Marble_2.GetComponent<pickUp_Marble_2>();
        pickUp_Marble_3 Marble_3_PickUp_Script = Marble_3.GetComponent<pickUp_Marble_3>();
        pickUp_Marble_Clue Marble_Clue_PickUp_Script = Marble_Clue.GetComponent<pickUp_Marble_Clue>();
        pickUp_Relic_1 Relic_1_PickUp_Script = Relic_1.GetComponent<pickUp_Relic_1>();
        pickUp_Battery Battery_PickUp_Script = Battery.GetComponent<pickUp_Battery>();
        pickUp_Bone Bone_PickUp_Script = Bone.GetComponent<pickUp_Bone>();
        pickUp_Relic_2 Relic_2_PickUp_Script = Relic_2.GetComponent<pickUp_Relic_2>();



        
        if (Marble_1_PickUp_Script.viewing_Marble_1){
            //Maybe find set invisible, and not not active
            Marble_1.transform.position = hideDest.position;
            //Update Sprite in Inventory
            Marble_1_Img.SetActive(true);
            //Set Viewing to False
            Marble_1_PickUp_Script.viewing_Marble_1 = false;

        } if (Marble_2_PickUp_Script.viewing_Marble_2){
            Marble_2.transform.position = hideDest.position;            
            Marble_2_Img.SetActive(true);
            Marble_2_PickUp_Script.viewing_Marble_2 = false;

        } if (Marble_3_PickUp_Script.viewing_Marble_3){
            Marble_3.transform.position = hideDest.position;            
            Marble_3_Img.SetActive(true);
            Marble_3_PickUp_Script.viewing_Marble_3 = false;

        } if (Marble_Clue_PickUp_Script.viewing_Marble_Clue){
            Marble_Clue.transform.position = hideDest.position;            
            Marble_Clue_Img.SetActive(true);
            Marble_Clue_PickUp_Script.viewing_Marble_Clue = false;

        } if (Relic_1_PickUp_Script.viewing_Relic_1){
            Relic_1.transform.position = hideDest.position;            
            Relic_1_Img.SetActive(true);
            Relic_1_PickUp_Script.viewing_Relic_1 = false;

        } if (Battery_PickUp_Script.viewing_Battery){
            Battery.transform.position = hideDest.position;            
            Battery_Img.SetActive(true);
            Battery_PickUp_Script.viewing_Battery = false;

        } if (Bone_PickUp_Script.viewing_Bone){
            Bone.transform.position = hideDest.position;            
            Bone_Img.SetActive(true);
            Bone_PickUp_Script.viewing_Bone = false;

        } if (Relic_2_PickUp_Script.viewing_Relic_2){
            Relic_2.transform.position = hideDest.position;            
            Relic_2_Img.SetActive(true);
            Relic_2_PickUp_Script.viewing_Relic_2 = false;

        }

    }


    public void putBackSpecificItem(){

        pickUp_Marble_1 Marble_1_PickUp_Script = Marble_1.GetComponent<pickUp_Marble_1>();
        pickUp_Marble_2 Marble_2_PickUp_Script = Marble_2.GetComponent<pickUp_Marble_2>();
        pickUp_Marble_3 Marble_3_PickUp_Script = Marble_3.GetComponent<pickUp_Marble_3>();
        pickUp_Marble_Clue Marble_Clue_PickUp_Script = Marble_Clue.GetComponent<pickUp_Marble_Clue>();
        pickUp_Relic_1 Relic_1_PickUp_Script = Relic_1.GetComponent<pickUp_Relic_1>();
        pickUp_Battery Battery_PickUp_Script = Battery.GetComponent<pickUp_Battery>();
        pickUp_Bone Bone_PickUp_Script = Bone.GetComponent<pickUp_Bone>();
        pickUp_Relic_2 Relic_2_PickUp_Script = Relic_2.GetComponent<pickUp_Relic_2>();



        if(Marble_1_PickUp_Script.viewing_Marble_1){
            //Place item back to oringal location
            Marble_1.transform.position = Marble_1_PickUp_Script.itemOPosition;
            Marble_1.transform.parent = Marble_1_PickUp_Script.parentOPosition;
            Marble_1_PickUp_Script.viewing_Marble_1 = false;
        } if (Marble_2_PickUp_Script.viewing_Marble_2){
            Marble_2.transform.position = Marble_2_PickUp_Script.itemOPosition;
            Marble_2.transform.parent = Marble_2_PickUp_Script.parentOPosition;
            Marble_2_PickUp_Script.viewing_Marble_2 = false;
        } if (Marble_3_PickUp_Script.viewing_Marble_3){
            Marble_3.transform.position = Marble_3_PickUp_Script.itemOPosition;
            Marble_3.transform.parent = Marble_3_PickUp_Script.parentOPosition;
            Marble_3_PickUp_Script.viewing_Marble_3 = false;
        } if (Marble_Clue_PickUp_Script.viewing_Marble_Clue){
            Marble_Clue.transform.position = Marble_Clue_PickUp_Script.itemOPosition;
            Marble_Clue.transform.parent = Marble_Clue_PickUp_Script.parentOPosition;
            Marble_Clue_PickUp_Script.viewing_Marble_Clue = false;
        } if (Relic_1_PickUp_Script.viewing_Relic_1){
            Relic_1.transform.position = Relic_1_PickUp_Script.itemOPosition;
            Relic_1.transform.parent = Relic_1_PickUp_Script.parentOPosition;
            Relic_1_PickUp_Script.viewing_Relic_1 = false;
        } if (Battery_PickUp_Script.viewing_Battery){
            Battery.transform.position = Battery_PickUp_Script.itemOPosition;
            Battery.transform.parent = Battery_PickUp_Script.parentOPosition;
            Battery_PickUp_Script.viewing_Battery = false;
        } if (Bone_PickUp_Script.viewing_Bone){
            Bone.transform.position = Bone_PickUp_Script.itemOPosition;
            Bone.transform.parent = Bone_PickUp_Script.parentOPosition;
            Bone_PickUp_Script.viewing_Bone = false;
        } if (Relic_2_PickUp_Script.viewing_Relic_2){
            Relic_2.transform.position = Relic_2_PickUp_Script.itemOPosition;
            Relic_2.transform.parent = Relic_2_PickUp_Script.parentOPosition;
            Relic_2_PickUp_Script.viewing_Relic_2 = false;
        }
    }

}
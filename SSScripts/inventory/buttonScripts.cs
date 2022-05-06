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

    //Cranes
    public GameObject Red_Crane;
    public GameObject Orange_Crane;
    public GameObject Yellow_Crane;
    public GameObject Green_Crane;
    public GameObject LightBlue_Crane;
    public GameObject Blue_Crane;
    public GameObject Purple_Crane;
    public GameObject Pink_Crane;
    public GameObject Relic_3;



    //ImagesButtons
    public GameObject Marble_1_Img;
    public GameObject Marble_2_Img;
    public GameObject Marble_3_Img;
    public GameObject Marble_Clue_Img;
    public GameObject Relic_1_Img;
    public GameObject Battery_Img;
    public GameObject Bone_Img;
    public GameObject Relic_2_Img;

    //Crane Buttons
    public GameObject Red_Crane_Img;
    public GameObject Orange_Crane_Img;
    public GameObject Yellow_Crane_Img;
    public GameObject Green_Crane_Img;
    public GameObject LightBlue_Crane_Img;
    public GameObject Blue_Crane_Img;
    public GameObject Purple_Crane_Img;
    public GameObject Pink_Crane_Img;
    public GameObject Relic_3_Img;




    public void Start(){
        Marble_1_Img.SetActive(false);
        Marble_2_Img.SetActive(false);
        Marble_3_Img.SetActive(false);
        Marble_Clue_Img.SetActive(false);
        Relic_1_Img.SetActive(false);
        Battery_Img.SetActive(false);
        Bone_Img.SetActive(false);
        Relic_2_Img.SetActive(false);

        Red_Crane_Img.SetActive(false);
        Orange_Crane_Img.SetActive(false);
        Yellow_Crane_Img.SetActive(false);
        Green_Crane_Img.SetActive(false);
        LightBlue_Crane_Img.SetActive(false);
        Blue_Crane_Img.SetActive(false);
        Purple_Crane_Img.SetActive(false);
        Pink_Crane_Img.SetActive(false);
        Relic_3_Img.SetActive(false);





        GameObject Marble_1 = GameObject.Find("Marble_1");    
        GameObject Marble_2 = GameObject.Find("Marble_2");
        GameObject Marble_3 = GameObject.Find("Marble_3");
        GameObject Marble_Clue = GameObject.Find("MarbleClue");
        GameObject Relic_1 = GameObject.Find("Relic_1");
        GameObject Battery = GameObject.Find("Battery");
        GameObject Bone = GameObject.Find("Bone");
        GameObject Relic_2 = GameObject.Find("Relic_2");

        GameObject Red_Crane = GameObject.Find("PaperCrane_RED");
        GameObject Orange_Crane = GameObject.Find("PaperCrane_ORANGE");
        GameObject Yellow_Crane = GameObject.Find("PaperCrane_YELLOW");
        GameObject Green_Crane = GameObject.Find("PaperCrane_GREEN");
        GameObject LightBlue_Crane = GameObject.Find("PaperCrane_lightBLUE");
        GameObject Blue_Crane = GameObject.Find("PaperCrane_BLUE");
        GameObject Purple_Crane = GameObject.Find("PaperCrane_PURPLE");
        GameObject Pink_Crane = GameObject.Find("PaperCrane_PINK");
        GameObject Relic_3 = GameObject.Find("Relic_3");


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

        pickUp_Red_Crane Red_Crane_PickUp_Script = Red_Crane.GetComponent<pickUp_Red_Crane>();
        pickUp_Orange_Crane Orange_Crane_PickUp_Script = Orange_Crane.GetComponent<pickUp_Orange_Crane>();
        pickUp_Yellow_Crane Yellow_Crane_PickUp_Script = Yellow_Crane.GetComponent<pickUp_Yellow_Crane>();
        pickUp_Green_Crane Green_Crane_PickUp_Script = Green_Crane.GetComponent<pickUp_Green_Crane>();
        pickUp_LightBlue_Crane LightBlue_Crane_PickUp_Script = LightBlue_Crane.GetComponent<pickUp_LightBlue_Crane>();
        pickUp_DarkBlue_Crane Blue_Crane_PickUp_Script = Blue_Crane.GetComponent<pickUp_DarkBlue_Crane>();
        pickUp_Purple_Crane Purple_Crane_PickUp_Script = Purple_Crane.GetComponent<pickUp_Purple_Crane>();
        pickUp_Pink_Crane Pink_Crane_PickUp_Script = Pink_Crane.GetComponent<pickUp_Pink_Crane>();
        pickUp_Relic_3 Relic_3_PickUp_Script = Relic_3.GetComponent<pickUp_Relic_3>();



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

        } if (Red_Crane_PickUp_Script.viewing_Red_Crane){
            Red_Crane.transform.position = hideDest.position;            
            Red_Crane_Img.SetActive(true);
            Red_Crane_PickUp_Script.viewing_Red_Crane = false;
        } if (Orange_Crane_PickUp_Script.viewing_Orange_Crane){
            Orange_Crane.transform.position = hideDest.position;            
            Orange_Crane_Img.SetActive(true);
            Orange_Crane_PickUp_Script.viewing_Orange_Crane = false;
        } if (Yellow_Crane_PickUp_Script.viewing_Yellow_Crane){
            Yellow_Crane.transform.position = hideDest.position;            
            Yellow_Crane_Img.SetActive(true);
            Yellow_Crane_PickUp_Script.viewing_Yellow_Crane = false;
        } if (Green_Crane_PickUp_Script.viewing_Green_Crane){
            Green_Crane.transform.position = hideDest.position;            
            Green_Crane_Img.SetActive(true);
            Green_Crane_PickUp_Script.viewing_Green_Crane = false;
        } if (LightBlue_Crane_PickUp_Script.viewing_lBlue_Crane){
            LightBlue_Crane.transform.position = hideDest.position;            
            LightBlue_Crane_Img.SetActive(true);
            LightBlue_Crane_PickUp_Script.viewing_lBlue_Crane = false;
        } if (Blue_Crane_PickUp_Script.viewing_dBlue_Crane){
            Blue_Crane.transform.position = hideDest.position;            
            Blue_Crane_Img.SetActive(true);
            Blue_Crane_PickUp_Script.viewing_dBlue_Crane = false;
        } if (Purple_Crane_PickUp_Script.viewing_Purple_Crane){
            Purple_Crane.transform.position = hideDest.position;            
            Purple_Crane_Img.SetActive(true);
            Purple_Crane_PickUp_Script.viewing_Purple_Crane = false;
        } if (Pink_Crane_PickUp_Script.viewing_Pink_Crane){
            Pink_Crane.transform.position = hideDest.position;            
            Pink_Crane_Img.SetActive(true);
            Pink_Crane_PickUp_Script.viewing_Pink_Crane = false;
        } if (Relic_3_PickUp_Script.viewing_Relic_3){
            Relic_3.transform.position = hideDest.position;            
            Relic_3_Img.SetActive(true);
            Relic_3_PickUp_Script.viewing_Relic_3 = false;
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

        pickUp_Red_Crane Red_Crane_PickUp_Script = Red_Crane.GetComponent<pickUp_Red_Crane>();
        pickUp_Orange_Crane Orange_Crane_PickUp_Script = Orange_Crane.GetComponent<pickUp_Orange_Crane>();
        pickUp_Yellow_Crane Yellow_Crane_PickUp_Script = Yellow_Crane.GetComponent<pickUp_Yellow_Crane>();
        pickUp_Green_Crane Green_Crane_PickUp_Script = Green_Crane.GetComponent<pickUp_Green_Crane>();
        pickUp_LightBlue_Crane LightBlue_Crane_PickUp_Script = LightBlue_Crane.GetComponent<pickUp_LightBlue_Crane>();
        pickUp_DarkBlue_Crane Blue_Crane_PickUp_Script = Blue_Crane.GetComponent<pickUp_DarkBlue_Crane>();
        pickUp_Purple_Crane Purple_Crane_PickUp_Script = Purple_Crane.GetComponent<pickUp_Purple_Crane>();
        pickUp_Pink_Crane Pink_Crane_PickUp_Script = Pink_Crane.GetComponent<pickUp_Pink_Crane>();
        pickUp_Relic_3 Relic_3_PickUp_Script = Relic_3.GetComponent<pickUp_Relic_3>();



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
        } if (Red_Crane_PickUp_Script.viewing_Red_Crane){
            Red_Crane.transform.position = Red_Crane_PickUp_Script.itemOPosition;
            Red_Crane.transform.parent = Red_Crane_PickUp_Script.parentOPosition;
            Red_Crane_PickUp_Script.viewing_Red_Crane = false;
        } if (Orange_Crane_PickUp_Script.viewing_Orange_Crane){
            Orange_Crane.transform.position = Orange_Crane_PickUp_Script.itemOPosition;
            Orange_Crane.transform.parent = Orange_Crane_PickUp_Script.parentOPosition;
            Orange_Crane_PickUp_Script.viewing_Orange_Crane = false;
        } if (Yellow_Crane_PickUp_Script.viewing_Yellow_Crane){
            Yellow_Crane.transform.position = Yellow_Crane_PickUp_Script.itemOPosition;
            Yellow_Crane.transform.parent = Yellow_Crane_PickUp_Script.parentOPosition;
            Yellow_Crane_PickUp_Script.viewing_Yellow_Crane = false;
        } if (Green_Crane_PickUp_Script.viewing_Green_Crane){
            Green_Crane.transform.position = Green_Crane_PickUp_Script.itemOPosition;
            Green_Crane.transform.parent = Green_Crane_PickUp_Script.parentOPosition;
            Green_Crane_PickUp_Script.viewing_Green_Crane = false;
        } if (LightBlue_Crane_PickUp_Script.viewing_lBlue_Crane){
            LightBlue_Crane.transform.position = LightBlue_Crane_PickUp_Script.itemOPosition;
            LightBlue_Crane.transform.parent = LightBlue_Crane_PickUp_Script.parentOPosition;
            LightBlue_Crane_PickUp_Script.viewing_lBlue_Crane = false;
        } if (Blue_Crane_PickUp_Script.viewing_dBlue_Crane){
            Blue_Crane.transform.position = Blue_Crane_PickUp_Script.itemOPosition;
            Blue_Crane.transform.parent = Blue_Crane_PickUp_Script.parentOPosition;
            Blue_Crane_PickUp_Script.viewing_dBlue_Crane = false;
        } if (Purple_Crane_PickUp_Script.viewing_Purple_Crane){
            Purple_Crane.transform.position = Purple_Crane_PickUp_Script.itemOPosition;
            Purple_Crane.transform.parent = Purple_Crane_PickUp_Script.parentOPosition;
            Purple_Crane_PickUp_Script.viewing_Purple_Crane = false;
        } if (Pink_Crane_PickUp_Script.viewing_Pink_Crane){
            Pink_Crane.transform.position = Pink_Crane_PickUp_Script.itemOPosition;
            Pink_Crane.transform.parent = Pink_Crane_PickUp_Script.parentOPosition;
            Pink_Crane_PickUp_Script.viewing_Pink_Crane = false;
        } if (Relic_3_PickUp_Script.viewing_Relic_3){
            Relic_3.transform.position = Relic_3_PickUp_Script.itemOPosition;
            Relic_3.transform.parent = Relic_3_PickUp_Script.parentOPosition;
            Relic_3_PickUp_Script.viewing_Relic_3 = false;
        }
    }

}
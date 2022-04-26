using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton

public class placeDown_Cranes : MonoBehaviour
{

    //This will be used for all cranes. Instead on placing the same crane in
    //its final position and worry about angleing, i will just make a copy
    //crane that will appear as if it was placed correctly.
    public Transform final_Crane_Dest; 

    //ImagesButtons
    public GameObject Red_Crane_Img;
    public GameObject Orange_Crane_Img;
    public GameObject Yellow_Crane_Img;
    public GameObject Green_Crane_Img;
    public GameObject LightBlue_Crane_Img;
    public GameObject DarkBlue_Crane_Img;
    public GameObject Purple_Crane_Img;
    public GameObject Pink_Crane_Img;

    //Stand-In Cranes
    public GameObject rsc; //Red Stand-In Crane
    public GameObject osc;   
    public GameObject ysc;  
    public GameObject gsc;
    public GameObject lbsc; 
    public GameObject dbsc; 
    public GameObject pusc; 
    public GameObject pisc; 

    public GameObject Relic_3;


    // Start is called before the first frame update
    void Start()
    { 
        rsc.SetActive(false); 
        osc.SetActive(false);   
        ysc.SetActive(false); 
        gsc.SetActive(false);
        lbsc.SetActive(false);
        dbsc.SetActive(false);
        pusc.SetActive(false);
        pisc.SetActive(false);

        Relic_3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Red_Crane = GameObject.Find("PaperCrane_RED");
        pickUp_Red_Crane Red_Crane_PickUp_Script = Red_Crane.GetComponent<pickUp_Red_Crane>();

        GameObject Orange_Crane = GameObject.Find("PaperCrane_ORANGE");
        pickUp_Orange_Crane Orange_Crane_PickUp_Script = Orange_Crane.GetComponent<pickUp_Orange_Crane>();

        GameObject Yellow_Crane = GameObject.Find("PaperCrane_YELLOW");
        pickUp_Yellow_Crane Yellow_Crane_PickUp_Script = Yellow_Crane.GetComponent<pickUp_Yellow_Crane>();

        GameObject Green_Crane = GameObject.Find("PaperCrane_GREEN");
        pickUp_Green_Crane Green_Crane_PickUp_Script = Green_Crane.GetComponent<pickUp_Green_Crane>();

        GameObject LightBlue_Crane = GameObject.Find("PaperCrane_lightBLUE");
        pickUp_LightBlue_Crane LightBlue_Crane_PickUp_Script = LightBlue_Crane.GetComponent<pickUp_LightBlue_Crane>();

        GameObject DarkBlue_Crane = GameObject.Find("PaperCrane_BLUE");
        pickUp_DarkBlue_Crane DarkBlue_Crane_PickUp_Script = DarkBlue_Crane.GetComponent<pickUp_DarkBlue_Crane>();

        GameObject Purple_Crane = GameObject.Find("PaperCrane_PURPLE");
        pickUp_Purple_Crane Purple_Crane_PickUp_Script = Purple_Crane.GetComponent<pickUp_Purple_Crane>();

        GameObject Pink_Crane = GameObject.Find("PaperCrane_PINK");
        pickUp_Pink_Crane Pink_Crane_PickUp_Script = Pink_Crane.GetComponent<pickUp_Pink_Crane>();

        //Once all the cranes have been placed, the third Relic appears
        

        if (Red_Crane_PickUp_Script.finalpos_Red_Crane  
            & Orange_Crane_PickUp_Script.finalpos_Orange_Crane
            & Yellow_Crane_PickUp_Script.finalpos_Yellow_Crane
            & Green_Crane_PickUp_Script.finalpos_Green_Crane
            & LightBlue_Crane_PickUp_Script.finalpos_lBlue_Crane
            & DarkBlue_Crane_PickUp_Script.finalpos_dBlue_Crane
            & Purple_Crane_PickUp_Script.finalpos_Purple_Crane
            & Pink_Crane_PickUp_Script.finalpos_Pink_Crane)  {
            
            Relic_3.SetActive(true);
            //Add sparkling sound effect

        }
    }


    void OnMouseDown(){

        GameObject Red_Crane = GameObject.Find("PaperCrane_RED");
        pickUp_Red_Crane Red_Crane_PickUp_Script = Red_Crane.GetComponent<pickUp_Red_Crane>();
        GameObject Orange_Crane = GameObject.Find("PaperCrane_ORANGE");
        pickUp_Orange_Crane Orange_Crane_PickUp_Script = Orange_Crane.GetComponent<pickUp_Orange_Crane>();
        GameObject Yellow_Crane = GameObject.Find("PaperCrane_YELLOW");
        pickUp_Yellow_Crane Yellow_Crane_PickUp_Script = Yellow_Crane.GetComponent<pickUp_Yellow_Crane>();
        GameObject Green_Crane = GameObject.Find("PaperCrane_GREEN");
        pickUp_Green_Crane Green_Crane_PickUp_Script = Green_Crane.GetComponent<pickUp_Green_Crane>();
        GameObject LightBlue_Crane = GameObject.Find("PaperCrane_lightBLUE");
        pickUp_LightBlue_Crane LightBlue_Crane_PickUp_Script = LightBlue_Crane.GetComponent<pickUp_LightBlue_Crane>();
        GameObject DarkBlue_Crane = GameObject.Find("PaperCrane_BLUE");
        pickUp_DarkBlue_Crane DarkBlue_Crane_PickUp_Script = DarkBlue_Crane.GetComponent<pickUp_DarkBlue_Crane>();
        GameObject Purple_Crane = GameObject.Find("PaperCrane_PURPLE");
        pickUp_Purple_Crane Purple_Crane_PickUp_Script = Purple_Crane.GetComponent<pickUp_Purple_Crane>();
        GameObject Pink_Crane = GameObject.Find("PaperCrane_PINK");
        pickUp_Pink_Crane Pink_Crane_PickUp_Script = Pink_Crane.GetComponent<pickUp_Pink_Crane>();

        if (Red_Crane_PickUp_Script.holding_Red_Crane){
            rsc.SetActive(true); 
            Red_Crane.GetComponent<Rigidbody>().useGravity = false;
            Red_Crane.transform.position = final_Crane_Dest.position;
            Red_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            Red_Crane_PickUp_Script.holding_Red_Crane = false;
            Red_Crane_PickUp_Script.finalpos_Red_Crane = true;
            Red_Crane_Img.SetActive(false);
            //Red_Crane.GetComponent<Renderer>().enabled = false;


        }if (Orange_Crane_PickUp_Script.holding_Orange_Crane){
            osc.SetActive(true);   
            Orange_Crane.GetComponent<Rigidbody>().useGravity = false;
            Orange_Crane.transform.position = final_Crane_Dest.position;
            Orange_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            Orange_Crane_PickUp_Script.holding_Orange_Crane = false;
            Orange_Crane_PickUp_Script.finalpos_Orange_Crane = true;
            Orange_Crane_Img.SetActive(false);
            //Orange_Crane.GetComponent<Renderer>().enabled = false;


        }if (Yellow_Crane_PickUp_Script.holding_Yellow_Crane){
            ysc.SetActive(true); 
            Yellow_Crane.GetComponent<Rigidbody>().useGravity = false;
            Yellow_Crane.transform.position = final_Crane_Dest.position;
            Yellow_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            Yellow_Crane_PickUp_Script.holding_Yellow_Crane = false;
            Yellow_Crane_PickUp_Script.finalpos_Yellow_Crane = true;
            Yellow_Crane_Img.SetActive(false);
            //Yellow_Crane.GetComponent<Renderer>().enabled = false;


        }if (Green_Crane_PickUp_Script.holding_Green_Crane){
            gsc.SetActive(true);
            Green_Crane.GetComponent<Rigidbody>().useGravity = false;
            Green_Crane.transform.position = final_Crane_Dest.position;
            Green_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            Green_Crane_PickUp_Script.holding_Green_Crane = false;
            Green_Crane_PickUp_Script.finalpos_Green_Crane = true;
            Green_Crane_Img.SetActive(false);
            //Green_Crane.GetComponent<Renderer>().enabled = false;


        }if (LightBlue_Crane_PickUp_Script.holding_lBlue_Crane){
            lbsc.SetActive(true);
            LightBlue_Crane.GetComponent<Rigidbody>().useGravity = false;
            LightBlue_Crane.transform.position = final_Crane_Dest.position;
            LightBlue_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            LightBlue_Crane_PickUp_Script.holding_lBlue_Crane = false;
            LightBlue_Crane_PickUp_Script.finalpos_lBlue_Crane = true;
            LightBlue_Crane_Img.SetActive(false);
            //LightBlue_Crane.GetComponent<Renderer>().enabled = false;


        }if (DarkBlue_Crane_PickUp_Script.holding_dBlue_Crane){
            dbsc.SetActive(true);
            DarkBlue_Crane.GetComponent<Rigidbody>().useGravity = false;
            DarkBlue_Crane.transform.position = final_Crane_Dest.position;
            DarkBlue_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            DarkBlue_Crane_PickUp_Script.holding_dBlue_Crane = false;
            DarkBlue_Crane_PickUp_Script.finalpos_dBlue_Crane = true;
            DarkBlue_Crane_Img.SetActive(false);
            //DarkBlue_Crane.GetComponent<Renderer>().enabled = false;


        }if (Purple_Crane_PickUp_Script.holding_Purple_Crane){
            pusc.SetActive(true);
            Purple_Crane.GetComponent<Rigidbody>().useGravity = false;
            Purple_Crane.transform.position = final_Crane_Dest.position;
            Purple_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            Purple_Crane_PickUp_Script.holding_Purple_Crane = false;
            Purple_Crane_PickUp_Script.finalpos_Purple_Crane = true;
            Purple_Crane_Img.SetActive(false);
            //Purple_Crane.GetComponent<Renderer>().enabled = false;


        }if (Pink_Crane_PickUp_Script.holding_Pink_Crane){
            pisc.SetActive(true);
            Pink_Crane.GetComponent<Rigidbody>().useGravity = false;
            Pink_Crane.transform.position = final_Crane_Dest.position;
            Pink_Crane.transform.parent = GameObject.Find("CraneFinalDestination").transform;
            Pink_Crane_PickUp_Script.holding_Pink_Crane = false;
            Pink_Crane_PickUp_Script.finalpos_Pink_Crane = true;
            Pink_Crane_Img.SetActive(false);
            //Pink_Crane.GetComponent<Renderer>().enabled = false;
        }


    }

}

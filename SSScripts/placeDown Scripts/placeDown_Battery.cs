using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton

public class placeDown_Battery : MonoBehaviour
{
    public Transform final_Battery_Dest;
    public GameObject Battery_Img;

    public Light UV_Light;
    public GameObject Secret_Message;


    void Start(){
        UV_Light.GetComponent<Light>().enabled = false;
        Secret_Message.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Battery = GameObject.Find("Battery");
        pickUp_Battery Battery_PickUp_Script = Battery.GetComponent<pickUp_Battery>();

        //If the Battery have been placed in the fuse box, then turn on the light
        if (Battery_PickUp_Script.finalpos_Battery){
            // Turn on UV light and reveal secret Message
            UV_Light.GetComponent<Light>().enabled = true;
            Secret_Message.SetActive(true);

        } if (!Battery_PickUp_Script.finalpos_Battery){
            UV_Light.GetComponent<Light>().enabled = false;
            Secret_Message.SetActive(false);
        }


    }


    void OnMouseDown() {

        GameObject Battery = GameObject.Find("Battery");
        pickUp_Battery Battery_PickUp_Script = Battery.GetComponent<pickUp_Battery>();

        if (Battery_PickUp_Script.holding_Battery){
            Battery.GetComponent<Rigidbody>().useGravity = false;
            Battery.transform.position = final_Battery_Dest.position;
            Battery.transform.parent = GameObject.Find("BatteryFinalDest").transform;
            Battery_PickUp_Script.holding_Battery = false;
            Battery_PickUp_Script.finalpos_Battery = true;
            Battery_Img.SetActive(false);


        } 

    }

}

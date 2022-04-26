using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton


public class placeDown_Bone : MonoBehaviour
{
    public Transform final_Bone_Dest;
    public GameObject Bone_Img;
    public GameObject nameplate;



    void Start(){

    nameplate.GetComponent<Animator>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Bone = GameObject.Find("Bone");
        pickUp_Bone Bone_PickUp_Script = Bone.GetComponent<pickUp_Bone>();

        //If the Bone have been placed on the Anubis Dog, then release second relic
        if (Bone_PickUp_Script.finalpos_Bone){
            //Release Relic and play a sound
            nameplate.GetComponent<Animator>().enabled = true;

        }

    }


    void OnMouseDown() {

        GameObject Bone = GameObject.Find("Bone");
        pickUp_Bone Bone_PickUp_Script = Bone.GetComponent<pickUp_Bone>();

        if (Bone_PickUp_Script.holding_Bone){
            Bone.GetComponent<Rigidbody>().useGravity = false;
            Bone.transform.position = final_Bone_Dest.position;
            Bone.transform.parent = GameObject.Find("GoldenBoneFinalDest").transform;
            Bone_PickUp_Script.holding_Bone = false;
            Bone_PickUp_Script.finalpos_Bone = true;
            Bone_Img.SetActive(false);


        } 

    }

}

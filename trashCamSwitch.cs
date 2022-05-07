using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCamSwitch : MonoBehaviour
{

    public GameObject trash1;
    public GameObject firstPersonCam;
    public bool isHiding;

    // Update is called once per frame
    void Start(){
        isHiding = false;
        trash1.SetActive(false);
        firstPersonCam.SetActive(true);
    }
    void Update()
    {
        if (Input.GetButtonDown("FKey") && !isHiding)
        {
            Debug.Log("press the f key ");
            trash1.SetActive(true);
            firstPersonCam.SetActive(false);
            isHiding = true;
        }
        if (Input.GetButtonDown("FKey") && isHiding)
        {
            trash1.SetActive(false);
            firstPersonCam.SetActive(true);
            isHiding =  false;

        }
    }

    
}

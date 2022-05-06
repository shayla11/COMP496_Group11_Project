using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton 

public class inventory : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Notebook;
    
    // Start is called before the first frame update
    void Start()
    {
        Inventory.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //Open Inventory on 'E' key press. Will close if pressed again
        if (Input.GetKeyDown(KeyCode.E) && !(Inventory.activeInHierarchy) && !(Notebook.activeInHierarchy)){
            Inventory.SetActive(true);

            //Player Movement is Restricted
            GameObject thePlayer = GameObject.Find("Player");
            GameObject theCamera = GameObject.Find("First Person Camera");
            playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
            mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
            playerScript.canMoveWASD = false;
            mouseScript.canMoveMouse = false;

        } else if (Input.GetKeyDown(KeyCode.E) && Inventory.activeInHierarchy){
            Inventory.SetActive(false);

            //Player Resumes Movement
            GameObject thePlayer = GameObject.Find("Player");
            GameObject theCamera = GameObject.Find("First Person Camera");
            playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
            mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
            playerScript.canMoveWASD = true;
            mouseScript.canMoveMouse = true;
        }
            
    }
}

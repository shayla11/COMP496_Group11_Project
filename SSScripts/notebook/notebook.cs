using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton 


public class notebook : MonoBehaviour
{

    public GameObject Notebook;
    public GameObject Inventory;

    void Start()
    {
        Notebook.SetActive(false);

    }

    void Update()
    {
        //Open Notebook on 'F' key press. Will close if pressed again
        if (Input.GetKeyDown(KeyCode.F) && !(Notebook.activeInHierarchy) && !(Inventory.activeInHierarchy)){
            Notebook.SetActive(true);
            restrictmovement();
        }
    }

    public void closeNotebook(){
        Notebook.SetActive(false);
        resumemovement();

    }














    public void resumemovement(){
        //Player Resumes Movement
        GameObject thePlayer = GameObject.Find("Player");
        GameObject theCamera = GameObject.Find("First Person Camera");
        playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
        mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
        playerScript.canMoveWASD = true;
        mouseScript.canMoveMouse = true;
    }

    public void restrictmovement(){
        //Player Movement is Restricted
        GameObject thePlayer = GameObject.Find("Player");
        GameObject theCamera = GameObject.Find("First Person Camera");
        playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
        mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
        playerScript.canMoveWASD = false;
        mouseScript.canMoveMouse = false;
    }

}

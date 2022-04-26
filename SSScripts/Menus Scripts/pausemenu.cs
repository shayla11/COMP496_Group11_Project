using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Author: Shayla Sexton


public class pausemenu : MonoBehaviour
{
    public GameObject Pause_Screen;

    
    // Start is called before the first frame update
    void Start()
    {
        Pause_Screen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        //Open Inventory on 'E' key press. Will close if pressed again
        if (Input.GetKeyDown(KeyCode.Escape) && !(Pause_Screen.activeInHierarchy)){
            ////// change to new 
            
            Pause_Screen.SetActive(true);
            ////

            //Player Movement is Restricted
            GameObject thePlayer = GameObject.Find("Player");
            GameObject theCamera = GameObject.Find("First Person Camera");
            playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
            mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
            playerScript.canMoveWASD = false;
            mouseScript.canMoveMouse = false;

        } else if (Input.GetKeyDown(KeyCode.Escape) && Pause_Screen.activeInHierarchy){
            Pause_Screen.SetActive(false);

            //Player Resumes Movement
            GameObject thePlayer = GameObject.Find("Player");
            GameObject theCamera = GameObject.Find("First Person Camera");
            playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
            mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
            playerScript.canMoveWASD = true;
            mouseScript.canMoveMouse = true;
        }
            
    }

    public void returnToGame(){
        Pause_Screen.SetActive(false);

        //Player Resumes Movement
        GameObject thePlayer = GameObject.Find("Player");
        GameObject theCamera = GameObject.Find("First Person Camera");
        playerMovement playerScript = thePlayer.GetComponent<playerMovement>();
        mouseLook mouseScript = theCamera.GetComponent<mouseLook>();
        playerScript.canMoveWASD = true;
        mouseScript.canMoveMouse = true;
    }

    public void QuitGameandReturnMenu(){
        SceneManager.LoadScene("Main Menu"); 
    }
    


    
}

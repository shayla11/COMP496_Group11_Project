using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Author: Shayla Sexton


public class mainmenu : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("KaylaRobinson_MuseumScene_March27"); //Use 'ShaylaTestEnv' to test puzzles and clues
    }

    public void QuitGame(){
        Debug.Log("QUIT");
        Application.Quit();
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardcollisions : MonoBehaviour
{

    public AudioClip pickupsound;
    AudioSource audioSource;
    public AudioClip losesound;


    public GameObject heart3;
    public GameObject heart2;
    public GameObject heart1;

    public int timesCaught;

    public GameObject losescreen;



    void Start(){
        audioSource = GetComponent<AudioSource>();
        timesCaught = 0;
        heart3.SetActive(true);
        heart2.SetActive(true);
        heart1.SetActive(true);
        losescreen.SetActive(false);


    }
    void Update(){
        if (timesCaught == 1){
            heart3.SetActive(false);
        } else if (timesCaught == 2){
            heart2.SetActive(false);
        } else if (timesCaught == 3){
            heart1.SetActive(false);
            //fade to black and say Game Over
            losescreen.SetActive(true);
            audioSource.PlayOneShot(losesound);



        }
    }


    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Enemy")){ // check if it's the player, if you want
            Debug.Log("Collide with Enemy");
            //play sound
            audioSource.PlayOneShot(pickupsound);
            timesCaught += 1;


        }
    }

}

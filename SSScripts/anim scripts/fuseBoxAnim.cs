using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton

public class fuseBoxAnim : MonoBehaviour
{

    public GameObject Fuse_Box_Door;
    public AudioClip pickupsound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Fuse_Box_Door.GetComponent<Animator>().enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown(){
        Fuse_Box_Door.GetComponent<Animator>().enabled = true;
        audioSource.PlayOneShot(pickupsound);

    }


}

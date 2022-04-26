using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Author: Shayla Sexton

public class keypad_button_script : MonoBehaviour
{
    public int keypadNumber = 1;
    public UnityEvent  KeypadClicked;

    private void OnMouseDown(){
        KeypadClicked.Invoke();
    }
}

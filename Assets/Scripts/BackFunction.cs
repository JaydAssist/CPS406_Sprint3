using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackFunction : MonoBehaviour
{
    public plrMovement playerMovement;
    public GameObject keypad;
    public TMP_InputField inputField;
    public void back(){
        playerMovement.EnableMovement();
        keypad.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        inputField.text = "";
    }
}

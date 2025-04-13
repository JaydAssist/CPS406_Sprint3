using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Safe_Back : MonoBehaviour
{
    public plrMovement playerMovement;
    public Canvas safeUI; 
    public TMP_InputField inputField;
    public void Exit(){
        playerMovement.EnableMovement();
        safeUI.gameObject.SetActive(false);
        inputField.text = "";
        
    }
}

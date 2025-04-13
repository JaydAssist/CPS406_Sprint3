using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SafeOpen : MonoBehaviour, IInteractable
{
    public GameObject closedSafe;
    public GameObject openedSafe;
    public TMP_InputField inputField;

    public void Interact(){
        if(string.Equals(inputField.text, "784159")){
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);
        }
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Safe_Enter : MonoBehaviour
{
 public plrMovement playerMovement;
 public Canvas safeUI;
 public TMP_InputField inputField;
 public Material newMaterial;
 public GameObject safeKeypad;

 public void Enter(){
    if(string.Equals(inputField.text, "784159")){
        playerMovement.EnableMovement();
        safeUI.gameObject.SetActive(false);
        safeKeypad.tag = "Untagged";
        ChangeColor();
    }
 }

 public void ChangeColor(){
    if (safeKeypad != null && newMaterial != null)
        {
            Renderer renderer = safeKeypad.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = newMaterial;
            }
        }
 }
}

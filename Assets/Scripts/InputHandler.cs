using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputHandler : MonoBehaviour
{
   public TMP_InputField inputField;
   public TMP_Text resultText;
   public plrMovement playerMovement;
   public GameObject keypadUI;
   public GameObject keypad;
   public Material newMaterial; // Assign this in the Inspector
public GameObject targetObject;
   public void ValidateInput(){
        string input = inputField.text;
        if (string.Equals(input, "2133")){
            Debug.Log("Correct");

            playerMovement.EnableMovement();
            keypadUI.SetActive(false);
            keypad.tag = "Untagged";

            ChangeColor();
        }
        else{
            Debug.Log("Incorrect");
        }
   }

   public void ChangeColor(){
    if (targetObject != null && newMaterial != null)
        {
            Renderer renderer = targetObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = newMaterial;
            }
        }
   }


}

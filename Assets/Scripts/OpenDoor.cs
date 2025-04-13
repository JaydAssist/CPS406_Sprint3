using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class OpenDoor : MonoBehaviour, IInteractable
{
  public Image image;
  public CharacterController controller;
  public TMP_InputField inputField; 
  public Animator anim;

  public plrMovement playerMovement;
  
  public void Interact(){
    //Debug.Log("GO THROUGH DOOR");
    if(string.Equals(inputField.text, "2133")){
        anim.Play("fadeOut");
        Debug.Log("GO THROUGH DOOR");
        playerMovement.DisableMovement();
        StartCoroutine(WaitForFadeThenStart());
    }

    IEnumerator WaitForFadeThenStart()
    {
        // Wait until image alpha is 0
        while (image.color.a < 1f)
        {
            yield return null; // wait one frame
        }

        controller.enabled = false; // disable to avoid conflict
        controller.transform.position = new Vector3(-9.625f, 1.354f, -16f);
        controller.enabled = true;

        StartCoroutine(FadeIn());
        
    }

    }
    IEnumerator FadeIn(){
        anim.Play("fadeAnim");

        while(image.color.a > 0f){
            yield return null;
        }
        playerMovement.EnableMovement();
        Cursor.lockState = CursorLockMode.Locked;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCode : MonoBehaviour, IInteractable
{

  public plrMovement playerMovement;
  public GameObject keypad;
  

  void Start(){
    keypad.SetActive(false);
  }

  public void Interact(){
    playerMovement.DisableMovement();
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
    keypad.SetActive(true);
    
  }

}

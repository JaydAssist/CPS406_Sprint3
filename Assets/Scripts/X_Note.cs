using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X_Note : MonoBehaviour
{
   public plrMovement playerMovement;
   public Image note;
   public void Exit(){
    playerMovement.EnableMovement();
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    note.gameObject.SetActive(false);
   }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteInteract : MonoBehaviour, IInteractable
{
    public Image note;
    public plrMovement playerMovement;
    
 
    public void Interact(){
        note.gameObject.SetActive(true);
        playerMovement.DisableMovement();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

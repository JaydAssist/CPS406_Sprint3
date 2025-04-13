using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hintInteract : MonoBehaviour, IInteractable
{
    public Image note;
    public plrMovement playerMovement;
    // Start is called before the first frame update
    
    public void Interact(){
        note.gameObject.SetActive(true);
        playerMovement.DisableMovement();
    }
}

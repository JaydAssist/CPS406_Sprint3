using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SafeInteract : MonoBehaviour, IInteractable
{
    public plrMovement playerMovement;
    public Canvas SafeUI;
    public void Interact(){
        SafeUI.gameObject.SetActive(true);
        playerMovement.DisableMovement();
        
    }
}

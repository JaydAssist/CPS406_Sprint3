using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RoomHint : MonoBehaviour, IInteractable
{
    public Canvas hint;
    public plrMovement playerMovement;
    public void Interact(){
        playerMovement.DisableMovement();
        hint.gameObject.SetActive(true);
    }
}

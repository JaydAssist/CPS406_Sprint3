using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class X_RoomHint : MonoBehaviour
{
    public plrMovement playerMovement;
    public Canvas hint;
    
    public void Exit(){
        playerMovement.EnableMovement();
        hint.gameObject.SetActive(false);

    }
}

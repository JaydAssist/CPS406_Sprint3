using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class x_Hint : MonoBehaviour
{
    public plrMovement playerMovement;
    public Image note;
    public void Exit(){
        playerMovement.EnableMovement();
        note.gameObject.SetActive(false);
    }
}

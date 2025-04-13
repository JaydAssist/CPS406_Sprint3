using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyInteractor : MonoBehaviour, IInteractable
{
    public GameObject keyModel;
    public void Interact(){
        keyModel.SetActive(false);
    }
}

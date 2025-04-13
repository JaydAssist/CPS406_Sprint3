using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonPress : MonoBehaviour, IInteractable
{   
    public GameObject button;
    public Camera plrCam;
    public Camera cutsceneCam;
    public Material newMaterial;
    public List<Renderer> targetRenderers;
    public List<TextMeshPro> codes;

    public int codeIndex = 0;
    
    public void Interact(){
        plrCam.gameObject.SetActive(false);
        cutsceneCam.gameObject.SetActive(true);
        button.tag = "Untagged";
        StartCoroutine(ChangeColor());

    }
    
    IEnumerator ChangeColor()
    {
        foreach (Renderer rend in targetRenderers)
        {
            yield return new WaitForSeconds(1f);
            Material[] mats = rend.materials;
            mats[2] = newMaterial;
            rend.materials = mats;
            codes[codeIndex].gameObject.SetActive(true);
            codeIndex++;
               
        }
        yield return new WaitForSeconds(2f);
        plrCam.gameObject.SetActive(true);
        cutsceneCam.gameObject.SetActive(false);

    }

}

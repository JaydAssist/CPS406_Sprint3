using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class OpenExitDoor : MonoBehaviour, IInteractable
{
    public Image image;
    public CharacterController controller;
    public Animator anim;
    public plrMovement playerMovement;
    public GameObject keyModel;
    public TMP_Text dialogueText;

    public float textDelay = 4f;
    private string[] lines = new string[]
    {
        "???: Hmm... you actually escaped",
        "???: I didn't actually think that you would make it out",
        "???: I think I've underestimated you",
        "???: Stay there, I'm coming to get you",
        ""
    };
    // Start is called before the first frame update
    public void Interact(){
        if(!keyModel.activeSelf){
            anim.Play("fadeOut");
            Debug.Log("GO THROUGH DOOR");
            playerMovement.DisableMovement();
            StartCoroutine(WaitForFadeThenStart());
        }
    }

    IEnumerator WaitForFadeThenStart()
    {
        // Wait until image alpha is 0
        while (image.color.a < 1f)
        {
            yield return null; // wait one frame
        }

        controller.enabled = false; // disable to avoid conflict
        controller.transform.position = new Vector3(-9.625f, 1.354f, -16f);
        controller.enabled = true;
        StartCoroutine(PlayDialogue());
    }

    IEnumerator PlayDialogue()
    {
        foreach (string line in lines)
        {
            dialogueText.text = line;
            yield return new WaitForSeconds(textDelay);
        }
        
        SceneManager.LoadScene("TitleScreen");
        
    }

    
}

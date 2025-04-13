using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 3f;
    public Camera playerCam; // assign your player camera here
    public GameObject interactPrompt; // UI prompt like "Press E to Interact"

    void Update()
    {
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactRange))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                interactPrompt.SetActive(true);
                

                if (Input.GetKeyDown(KeyCode.E))
                {
            
                    hit.collider.GetComponent<IInteractable>()?.Interact();
                }
            }
            
            else
            {
                interactPrompt.SetActive(false);
            }
        }
        else
        {
            interactPrompt.SetActive(false);
        }
    }
}
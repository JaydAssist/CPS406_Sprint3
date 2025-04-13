using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IntroDialogue : MonoBehaviour
{
    public bool x = true;
    public Image image;
    public TMP_Text dialogueText;
    public float textDelay = 7f;

    private string[] lines = new string[]
    {
        "???: Ah... you’re awake.",
        "???: I wouldn’t waste time trying to remember how you got here.",
        "???: You’re trapped. This is your only chance.",
        "???: You better get out of here or...",
        "???: Well, let's just say you won’t be here for much longer.",
        "???: The clock’s ticking.",
        ""
    };

    void Start()
    {
        StartCoroutine(WaitForFadeThenStart());
    }

    IEnumerator WaitForFadeThenStart()
    {
        // Wait until image alpha is 0
        while (image.color.a > 0f)
        {
            yield return null; // wait one frame
        }

        // Now start the dialogue
        StartCoroutine(PlayDialogue());
    }

    IEnumerator PlayDialogue()
    {
        foreach (string line in lines)
        {
            dialogueText.text = line;
            yield return new WaitForSeconds(textDelay);
        }

        
    }
}
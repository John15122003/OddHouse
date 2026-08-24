using UnityEngine;
using TMPro;
using System.Collections;

public class Dialogue : MonoBehaviour
{
    public GameObject DialogueText;
    public TextMeshProUGUI dialogueTextObject;
    public string textToDisplay;

    public float delaySeconds = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    void Start()
    {
        
    }

    IEnumerator HideTextAfterDelay()
    {
        dialogueTextObject.text = textToDisplay;
        // Wait for the specified time
        yield return new WaitForSeconds(3);
        dialogueTextObject.text = "";
        // Hide the text object without destroying it
        DialogueText.SetActive(false);
    }
    public void DialogueClickedOn()
    {
        StartCoroutine(HideTextAfterDelay());
        
        Debug.Log("display dialogue");
        Invoke("ResetText", 3);
        
        
    }

    IEnumerator TimeDisplayText()
    {
        Debug.Log("Coroutine Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Coroutine ended");
    }

}


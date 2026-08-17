using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public string dialogueText;
    public TextMeshProUGUI displayText;
    public Animator displayTextAnimator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        displayText.text = dialogueText;
        displayTextAnimator.SetTrigger("DisplayText");


    }


}

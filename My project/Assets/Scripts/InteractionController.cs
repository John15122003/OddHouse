using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionController : MonoBehaviour
{
    //The sprite used to highlight when the player can interact with something
    public GameObject exclaimSprite;
    Camera thisCamera;
    GameObject objectCurrentlyOver;

    void Start()
    {
        thisCamera = this.GetComponent<Camera>();
    }

    //Using Raycasting to allow the player to interact with objects
    //This is done to allow us to detect only the object we are currently looking at
    //and to check if it is in range
    void Update()
    {
        Ray rayToCast = thisCamera.ScreenPointToRay(Mouse.current.position.ReadValue());

        bool canInteract = true;

        if(Physics.Raycast(rayToCast, out RaycastHit hitInfo, 2f))
        {
            //Only allow interacting with correclty tagged objects, meaning we wont collect random objects
            if (hitInfo.collider.gameObject.CompareTag("Interactive"))
            {
                objectCurrentlyOver = hitInfo.collider.gameObject;
                if(objectCurrentlyOver.GetComponent<AnimatorController>() != null)
                {
                    canInteract = !objectCurrentlyOver.GetComponent<AnimatorController>().isLocked && !objectCurrentlyOver.GetComponent<AnimatorController>().hasBeenInteractedWith;
                }
            }
            else
            {
                objectCurrentlyOver = null;
            }            
        }
        else
        {
            objectCurrentlyOver = null;
        }

        Debug.Log(objectCurrentlyOver);
        
        //Only certain componets can be interacted with, so run through them all and run the click on function only for these components
        //use an array for the components to enable using more than one on a single collider
        if(Mouse.current.leftButton.wasPressedThisFrame && objectCurrentlyOver != null)
        {
            AnimatorController[] animatorControllers;
            animatorControllers = objectCurrentlyOver.GetComponents<AnimatorController>();
            if(animatorControllers.Length > 0)
            {
                foreach(AnimatorController animController in animatorControllers)
                {
                    animController.ObjectClickedOn();
                }
            }

            UnlockAnimator[] unlockAnimators;
            unlockAnimators = objectCurrentlyOver.GetComponents<UnlockAnimator>();
            if(unlockAnimators.Length > 0)
            {
                foreach(UnlockAnimator animUnlock in unlockAnimators)
                {
                    animUnlock.ObjectClickedOn();
                }
            }

            Dialogue[] dialogueScript;
            dialogueScript = objectCurrentlyOver.GetComponents<Dialogue>();
            if(dialogueScript.Length > 0)
            {
                foreach(Dialogue singularDialogue in dialogueScript)
                {
                    singularDialogue.DialogueClickedOn();
                }
            }

            FadeCode[] fade;
            fade = objectCurrentlyOver.GetComponents<FadeCode>();

            if(fade.Length > 0)
            {
                foreach(FadeCode fadeObject in fade)
                {
                    fadeObject.FadeToBlack();
                }
            }
        }

        //Use the existance of an object to click on to turn on/off the excalimation sprite
        if(objectCurrentlyOver != null && exclaimSprite != null)
        {
             exclaimSprite.SetActive(canInteract);
        }
        else if(exclaimSprite != null)
        {
            exclaimSprite.SetActive(false);
        }
        
    }

}

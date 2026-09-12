using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator objectToAnimate;
    public string openBooleanName;

    // Controls if this script is able to be interacted with
    public bool isLocked;

    public bool hasBeenInteractedWith;

    // Keeps track of whether the door is open
    private bool isOpen = false;

    // The function called by the InteractionController
    public void ObjectClickedOn()
    {
        if (isLocked == false)
        {
            // Toggle the door
            isOpen = !isOpen;

            // Tell the Animator to open or close
            objectToAnimate.SetBool(openBooleanName, isOpen);

            hasBeenInteractedWith = true;
        }
    }
}


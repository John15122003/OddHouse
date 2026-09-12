using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAnimator : MonoBehaviour
{
    public AnimatorController doorToUnlock;
    public bool turnOffObject;
    public bool isLocked = true;

    bool hasBeenInteractedWith;

    // The function called by the InteractionController
    public void ObjectClickedOn()
    {
        // Unlock the door
        doorToUnlock.isLocked = false;

        hasBeenInteractedWith = true;

        // Turn off this object?
        if (turnOffObject)
        {
            this.gameObject.SetActive(false);
        }
    }
}



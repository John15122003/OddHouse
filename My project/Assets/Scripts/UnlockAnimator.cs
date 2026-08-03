using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAnimator : MonoBehaviour
{
    public AnimatorController doorToUnlock;
    public bool turnOffObject;

    bool hasBeenInteractedWith;

    //The function called by the InteractionController
    public void ObjectClickedOn()
    {
        //sets the door to be interactable
        doorToUnlock.isLocked = false;
        hasBeenInteractedWith = true;
        //turn off this object?
        if (turnOffObject)
        {
            this.gameObject.SetActive(false);
        }
    }
}

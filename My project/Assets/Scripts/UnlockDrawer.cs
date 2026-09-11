using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDrawer : MonoBehaviour
{
    public AnimatorController drawerToUnlock;
    public bool turnOffObject;

    bool hasBeenInteractedWith;

    //The function called by the InteractionController
    public void ObjectClickedOn()
    {
        //sets the door to be interactable
        drawerToUnlock.isLocked = false;
        hasBeenInteractedWith = true;
        //turn off this object?
        if (turnOffObject)
        {
            this.gameObject.SetActive(false);
        }
    }
}

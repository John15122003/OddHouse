using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator objectToAnimate;
    public string openBooleanName;
    //controls if this script is able to be interacted with
    public bool isLocked;
    public bool hasBeenInteractedWith;

    //The function called by the InteractionController
    public void ObjectClickedOn()
    {
        if(isLocked == false)
        {
            objectToAnimate.SetBool(openBooleanName, true);
            hasBeenInteractedWith = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCard : MonoBehaviour
{
    public Animator titleCardAnimator;
    public string titleCardBoolean;
    public AudioSource bgMusic;

    //Using on trigger to detect when player has moved into the game area to begin rather than just starting straight away
    //using animations for the titlecard to allow for more customisation
    private void OnTriggerEnter(Collider other)
    {
        titleCardAnimator.SetBool(titleCardBoolean, true);
        if(bgMusic.isPlaying == false)
        {
            bgMusic.Play();
        }
        
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedText : MonoBehaviour
{
    //[SerializeField] AudioSource audioSourcName;
    //[SerializeField] AudioClip clip;
    GameObject playButton;

    public void PlayButtonFunc()
    { 
            Animator anim = playButton.GetComponent<Animator>();
            if (anim != null) anim.Play("PlayButtonAnim");

            //Soundname.PlayOneShot(clip);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySorter : MonoBehaviour
{
    [SerializeField] AudioSource[] audioSources;
    [SerializeField] static readonly float[] frequency = {261.63f, 277.18f, 293.66f, 311.13f, 329.63f, 349.23f, 369.99f, 392.00f, 415.30f, 440.00f, 466.16f, 493.88f, 523.25f};
    void Awake(){
        for(int i = 0; i < audioSources.Length; i++){
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySorter : MonoBehaviour
{
    [SerializeField] AudioPlayer[] audioPlayers;
    [SerializeField] public static readonly float[] frequency = {261.63f, 277.18f, 293.66f, 311.13f, 329.63f, 349.23f, 369.99f, 392.00f, 415.30f, 440.00f, 466.16f, 493.88f, 523.25f};
    [SerializeField, Range(0, 11)] int frequencyID;
    [SerializeField] int audioPlayersID;
    void Awake(){
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.P)){
            audioPlayers[audioPlayersID].AudioPlay(frequency[frequencyID]);
            Debug.Log("P pressed");
        }
        if(Input.GetKeyUp(KeyCode.O)){
            audioPlayers[audioPlayersID].AudioPause();
            Debug.Log("O pressed");
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)){
            frequencyID--;
            if(frequencyID < 0){
                frequencyID = frequency.Length - 1;
            }
            Debug.Log("DownArrow pressed");
        }
        if(Input.GetKeyUp(KeyCode.UpArrow)){
            frequencyID++;
            if(frequencyID >= frequency.Length){
                frequencyID = 0;
            }
            Debug.Log("UpArrow pressed");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow)){
            audioPlayersID++;
            if(audioPlayersID >= audioPlayers.Length){
                audioPlayersID = 0;
            }
            Debug.Log("RightArrow pressed");
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)){
            audioPlayersID--;
            if(audioPlayersID < 0){
                audioPlayersID = audioPlayers.Length - 1;
            }
            Debug.Log("LeftArrow pressed");
        }
    }
}
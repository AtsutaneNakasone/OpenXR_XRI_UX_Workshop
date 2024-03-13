using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField, Range(0, 1)] float amplitude = 0.5f;
    [SerializeField] float frequency = 261.63f;
    public AudioSource audioSource;
    double _phase;
    int _sampleRate;

    void Awake(){
        audioSource = GetComponent<AudioSource>();
        _sampleRate = AudioSettings.outputSampleRate;
        AudioPause();
        Debug.Log("Audio is supposed to stop at awake");
    }

    void OnAudioFilterRead(float[] data, int channels){
        double phaseIncrement = frequency / _sampleRate;

        for(int sample = 0; sample < data.Length; sample += channels){
            float value = Mathf.Sin((float) _phase * 2 * Mathf.PI) * amplitude;

            _phase = (_phase + phaseIncrement) % 1;

            for (int channel = 0; channel < channels; channel++){
                data[sample + channel] = value;
            }
        }
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.P)){
            AudioPlay(261.63f);
            Debug.Log("P pressed");
        }
        if(Input.GetKeyUp(KeyCode.O)){
            AudioPause();
            Debug.Log("O pressed");
        }
    }
    public void AudioPlay(float keyID){
        audioSource.Play();
        frequency = keyID;
        Debug.Log("AudioPlay called");
    }
    public void AudioPause(){
        audioSource.Stop();
        Debug.Log("AudioPause called");
    }
}

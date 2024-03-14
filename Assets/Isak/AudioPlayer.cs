using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField, Range(0, 1)] float amplitude = 0.5f;
    [SerializeField] float frequency = 261.63f;
    public AudioSource audioSource;
    double _phase, increment;
    int _sampleRate;
    [SerializeField, Range(0, 0.2f)]float gain;

    void Awake(){
        audioSource = GetComponent<AudioSource>();
        _sampleRate = AudioSettings.outputSampleRate;
        AudioPause();
        Debug.Log("Audio is supposed to stop at awake");
    }

    void OnAudioFilterRead(float[] data, int channels){
        /*double phaseIncrement = frequency / _sampleRate;

        for(int sample = 0; sample < data.Length; sample += channels){
            float value = Mathf.Sin((float) _phase * 2 * Mathf.PI) * amplitude;

            _phase = (_phase + phaseIncrement) % 1;

            for (int channel = 0; channel < channels; channel++){
                data[sample + channel] = value;
            }
        }*/
        increment = frequency * 2.0 * Mathf.PI / _sampleRate;
        
        for(int i = 0; i < data.Length; i += channels){
            _phase += increment;
            //data[i] = (float)(gain * Mathf.Sin((float)_phase));
            if(gain * Mathf.Sin((float)_phase) >= 0 * gain){
                data[i] = (float)gain * 0.6f;
            } else {
                data[i] = (-(float)gain) *0.6f;
            }
            if(channels == 2){
                data[i + 1] = data[i];
            }
            if(_phase > (Mathf.PI * 2)){
                _phase = 0.0f;
            }
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

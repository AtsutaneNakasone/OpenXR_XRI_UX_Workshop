using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField, Range(0, 1)] float amplitude = 0.5f;
    [SerializeField] static readonly float[] frequency = {261.63f, 277.18f, 293.66f, 311.13f, 329.63f, 349.23f, 369.99f, 392.00f, 415.30f, 440.00f, 466.16f, 493.88f, 523.25f};
    [SerializeField, Range(0, 11)] int note = 0;

    double _phase;
    int _sampleRate;

    void Awake(){
        _sampleRate = AudioSettings.outputSampleRate;
    }

    void OnAudioFilterRead(float[] data, int channels){
        double phaseIncrement = frequency[note] / _sampleRate;

        for(int sample = 0; sample < data.Length; sample += channels){
            float value = Mathf.Sin((float) _phase * 2 * Mathf.PI) * amplitude;

            _phase = (_phase + phaseIncrement) % 1;

            for (int channel = 0; channel < channels; channel++){
                data[sample + channel] = value;
            }
        }
    }
}

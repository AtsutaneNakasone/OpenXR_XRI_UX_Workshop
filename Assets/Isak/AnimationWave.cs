using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWave : MonoBehaviour
{
    KeySorter keySorter;
    Vector3 newPosition;
    [SerializeField] float speed = 0.1f, size = 0.1f;
    float frequency;
    float offset;

    /*void Awake(){
        keySorter = transform.parent.parent.GetComponent<KeySorter>();
        offset = Random.Range(0, 1f);
    }
    void Update(){
        newPosition = transform.position;
        newPosition.y += Mathf.Cos(Time.time + offset) * Time.deltaTime * speed;
        transform.position = newPosition;
        transform.localScale += new Vector3(1f, 1f, 1f) * Mathf.Cos(Time.time + offset) * Time.deltaTime * size;
    }*/

    ///New script here but sharing space for lazyness
    ///
    void OnCollisionEnter(){

    }
    public void AssignID(float frequencyID){
        frequency = frequencyID;
    }
    void OnMouseDown(){
        Debug.Log($"Hit {this.gameObject}");
        keySorter.KeyPressed(frequency);
    }
    void OnMouseUp(){
        keySorter.KeyReleased();
    }
}

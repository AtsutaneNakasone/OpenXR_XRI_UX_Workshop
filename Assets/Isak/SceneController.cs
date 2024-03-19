using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject[] scenes;

    public void ChangeScene(GameObject sceneInput){
        for(int i = 0; i < scenes.Length; i++){
            scenes[i].SetActive(false);
        }
        sceneInput.SetActive(true);
    }
    public void ExitScene(){
        for(int i = 0; i < scenes.Length; i++){
            scenes[i].SetActive(false);
        }
        scenes[0].SetActive(true);
    }
}

using UnityEngine;

public class AnimatedText : MonoBehaviour
{
    //[SerializeField] AudioSource audioSourcName;
    //[SerializeField] AudioClip clip;
    [SerializeField] GameObject triangleButtonPlay;

    private GameObject playButton;
    private GameObject graphicsButton;
    private GameObject audioButton;
    private GameObject exitButton;
    private GameObject gameModeButton;

    public void PlayButtonFunc()
    {
        Animator anim = playButton.GetComponent<Animator>();
        if (anim != null) anim.Play("PlayButtonAnim");

        //Soundname.PlayOneShot(clip);
    }

    public void GraphicsButtonFunc()
    {
        Animator anim = graphicsButton.GetComponent<Animator>();
        if (anim != null) anim.Play("GraphicsButtonAnim");

        //Soundname.PlayOneShot(clip);
    }

    public void AudioButtonFunc()
    {
        Animator anim = audioButton.GetComponent<Animator>();
        if (anim != null) anim.Play("AudioButtonAnim");

        //Soundname.PlayOneShot(clip);
    }

    public void ExitButtonFunc()
    {
        Animator anim = exitButton.GetComponent<Animator>();
        if (anim != null) anim.Play("ExitButtonAnim");

        //Soundname.PlayOneShot(clip);
    }

    public void GameModeButtonFunc()
    {
        Animator anim = gameModeButton.GetComponent<Animator>();
        if (anim != null) anim.Play("GameModeAnim");

        //Soundname.PlayOneShot(clip);
    }

}
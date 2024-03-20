using UnityEngine;

public class AnimatedText : MonoBehaviour
{
    //[SerializeField] AudioSource audioSourcName;
    //[SerializeField] AudioClip clip;
    //[SerializeField] GameObject triangleButtonPlay;

    private GameObject playButton;
    private GameObject graphicsButton;
    private GameObject audioButton;
    private GameObject exitButton;
    private GameObject gameModeButton;
    [SerializeField] private Animator playAnim;

    public void PlayButtonFunc()
    {
        Debug.Log("playbutton F(x) has been initiated");
        playAnim.SetBool("OpenMenu", true);
        //if (playAnim != null) playAnim.Play("PlayButtonAnim");

        //Soundname.PlayOneShot(clip);
    }
    /*
        public void PlayButtonFuncOff()
    {
        Debug.Log("playbutton F(x) has been terminated");
        playAnim.SetBool("OpenMenu", false);
        //if (playAnim != null) playAnim.Play("PlayButtonAnim");

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
*/
}
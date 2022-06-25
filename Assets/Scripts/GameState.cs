using UnityEngine;

public class GameState : MonoBehaviour
{
    //public AudioSource Instrumental;
    //public AudioSource Vocals;
    public static GameState instance;
    public float FPSCap = 61;
    void Start()
    {
        //Instrumental.Play();
        //Vocals.Play();

        // Runs the game in the background
        Application.runInBackground = true;
        // FPS Cap
        Application.targetFrameRate = (int)FPSCap;
        instance = this;
    }

    void Update()
    {

    }

}

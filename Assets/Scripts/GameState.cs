using UnityEngine;

public class GameState : MonoBehaviour
{
    //public AudioSource Instrumental;
    //public AudioSource Vocals;
    public static GameState instance;

    void Start()
    {
        instance = this;
        //Instrumental.Play();
        //Vocals.Play();
    }

    void Update()
    {

    }

    public void daNoteHit()
    {
       
    }
    public void daNoteMiss()
    {

    }
}

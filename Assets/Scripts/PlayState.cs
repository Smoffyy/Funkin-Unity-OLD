using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : MonoBehaviour
{
    public AudioSource Instrumental;
    public AudioSource Vocals;
    public Scroller BPM;
    public Scroller BPM_Opponent;
    public static PlayState instance;
    
    void Start() {
        instance = this; 
        Instrumental.Play();
        Vocals.Play();    
    }
        
    void Update() {

    } 

    public void daNoteHit() {
        //Debug.Log("Note Hit");
    }
    public void daNoteMiss() {
        //Debug.Log("Note Miss");
    }
}

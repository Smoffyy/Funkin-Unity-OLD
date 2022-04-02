using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public AudioSource Instrumental;
    public AudioSource Vocals;
    public Scroller BPM;
    public static Manager instance;
    
    void Start() {
        Instrumental.Play();
        Vocals.Play();
        instance = this;     
    }
        
    void Update() {

    } 

    public void daNoteHit() {
        
    }
    public void daNoteMiss() {
        
    }
}

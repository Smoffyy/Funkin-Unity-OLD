using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public KeyCode altKeyToPress;

    void Start() {

    }
    void Update() {
        if(Input.GetKeyDown(keyToPress)) {
            if(canBePressed) {
                gameObject.SetActive(false);
                PlayState.instance.daNoteHit();
            }
        }
             // Alt Keybind
            if(Input.GetKeyDown(altKeyToPress)) {
            if(canBePressed) {   
                gameObject.SetActive(false);
                PlayState.instance.daNoteHit();
            }
        }
    }    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Active") {
            canBePressed = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (gameObject.activeSelf) {
            canBePressed = false;
            PlayState.instance.daNoteMiss();
        }
        
    }
}

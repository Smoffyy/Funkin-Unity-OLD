using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldNote : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public KeyCode altKeyToPress;

    void Start() {

    }
    void Update() {
        // Uses GetKey since it needs to check if its held
        if(Input.GetKey(keyToPress)) {
            if(canBePressed) {
                gameObject.SetActive(false);
                GameState.instance.daNoteHit();
            }
        }
             // Alt Keybind
            if(Input.GetKey(altKeyToPress)) {
            if(canBePressed) {   
                gameObject.SetActive(false);
                GameState.instance.daNoteHit();
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
            gameObject.SetActive(false);
            GameState.instance.daNoteMiss();
        }
        
    }
}

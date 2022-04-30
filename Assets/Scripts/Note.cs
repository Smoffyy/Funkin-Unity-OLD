using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public bool canBePressed;
    public KeyCode keyToPress;
    public KeyCode altKeyToPress;
    

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update() {
        if(Input.GetKeyDown(keyToPress)) {
            if(canBePressed) {
                gameObject.SetActive(false);
                GameState.instance.daNoteHit();
            }
        }
             // Alt Keybind
            if(Input.GetKeyDown(altKeyToPress)) {
            if(canBePressed) {   
                gameObject.SetActive(false);
                GameState.instance.daNoteMiss();
            }
        }  
             // Autoplay
        if (Input.GetKey("1")) {
                 if(canBePressed) {
                gameObject.SetActive(false);
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
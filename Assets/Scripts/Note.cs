using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {

    public bool canBePressed;
    public static Note instance;
    public KeyCode keyBind;
    public KeyCode altKeyBind;

    void Start() {

    }
    void Update()
    {
        if (Input.GetKeyDown(keyBind)) {
            if (canBePressed) {
                gameObject.SetActive(false);
                GameState.instance.daNoteHit();
            }
        }
        // Alt Keybind
        if (Input.GetKeyDown(altKeyBind)) {
            if (canBePressed) {
                gameObject.SetActive(false);
                GameState.instance.daNoteHit();
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Active") {
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

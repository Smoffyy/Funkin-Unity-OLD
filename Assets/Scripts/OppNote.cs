using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppNote : MonoBehaviour
{
    public bool canBePressed;
    //public static OppNote instance;

    void Start() {

    }
    void Update() {

    }    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "ActiveOp") {
            canBePressed = true;
            gameObject.SetActive(false);
            PlayState.instance.daNoteHit();
            
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (gameObject.activeSelf) {
            canBePressed = false;
            gameObject.SetActive(false);
            PlayState.instance.daNoteHit();
            
        }
    }
}

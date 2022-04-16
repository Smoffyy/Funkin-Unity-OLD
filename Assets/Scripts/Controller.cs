using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public AnimationClip pressedAnimation;

    public KeyCode keyBind;
    public KeyCode altKeyBind;
    private Animator animator;
    // Play the pressed animation when the key is pressed
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {   // Keybind
        if(Input.GetKeyDown(keyBind)) {
            animator.Play("pressedAnimation");
        }
        if(Input.GetKeyUp(keyBind)) {

        }

        // Alt Keybind
        if(Input.GetKeyDown(altKeyBind)) {

        }
        if(Input.GetKeyUp(altKeyBind)) {

        }
        
    }
}

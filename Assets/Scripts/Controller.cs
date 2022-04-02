using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite defaultSprite;
    public Sprite pressedSprite;
    //public sprite hitSprite;

    public KeyCode keyBind;
    public KeyCode altKeyBind;
    
    void Start()
    {
        spriteRenderer = GetComponent<spriteRenderer>();
    }

    
    void Update()
    {   // Keybind
        if(Input.GetKeyDown(keyBind)) {
            spriteRenderer = pressedSprite;
        }
        if(Input.GetKeyUp(keyBind)) {
            spriteRenderer = defaultSprite;
        }

        // Alt Keybind
        if(Input.GetKeyDown(altKeyBind)) {
            spriteRenderer = pressedSprite;
        }
        if(Input.GetKeyUp(altKeyBind)) {
            spriteRenderer = defaultSprite;
        }
        
    }
}

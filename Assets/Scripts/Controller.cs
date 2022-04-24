using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite defaultSprite;
    public Sprite pressedSprite;
    public KeyCode keyBind;
    public KeyCode altKeyBind;
    public Sprite hitSprite;
    public static GameState instance;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {   // Keybind
        if(Input.GetKeyDown(keyBind)) {
            spriteRenderer.sprite = pressedSprite;
        }
        if(Input.GetKeyUp(keyBind)) {
            spriteRenderer.sprite = defaultSprite;
        }

        // Alt Keybind
        if(Input.GetKeyDown(altKeyBind)) {
            spriteRenderer.sprite = pressedSprite;
        }
        if(Input.GetKeyUp(altKeyBind)) {
            spriteRenderer.sprite = defaultSprite;
        }      
    }
}
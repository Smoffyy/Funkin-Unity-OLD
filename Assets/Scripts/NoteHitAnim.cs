using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHitAnim : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    //public AnimationClip hitAnimation;
    

    public Sprite hitAnim;
    public Sprite idleAnim;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) { // On collide with the collider
    
        spriteRenderer.sprite = hitAnim; // Hit anim
        //anim.Play("hitAnimation");
    }

    void OnTriggerExit2D(Collider2D other) {

        spriteRenderer.sprite = idleAnim; // Hit anim
    }

}

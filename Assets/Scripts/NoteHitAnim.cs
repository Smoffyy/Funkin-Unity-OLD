using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHitAnim : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite hitAnim;
    public Sprite idleAnim;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) { // On collide with the collider
        spriteRenderer.sprite = hitAnim; // Hit anim
    }

    void OnTriggerExit2D(Collider2D other) {

        new WaitForSeconds(1);
        //yield return new WaitForSeconds(3);
        spriteRenderer.sprite = idleAnim; // Hit anim
    }

}

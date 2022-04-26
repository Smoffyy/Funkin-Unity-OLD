/*
using UnityEngine;

public class OppControl : MonoBehaviour {

    [SerializeField] private Animator anim;

    void Start() {
    
    }

    void Update() {
    
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Left"))
        anim.SetBool("Confirm", true);
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Left"))
        anim.SetBool("Confirm", false);
    }
*/
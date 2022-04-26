using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float BPM = 100f;

    void Start() {

    }

    void Update() {
        // If you want down scroll, use positive values
            gameObject.transform.position -= new Vector3(0f, -scrollSpeed * Time.deltaTime, 0f);
    }
}

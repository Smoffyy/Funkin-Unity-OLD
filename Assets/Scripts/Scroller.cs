using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float scrollSpeed;
    public float BPM;

    void Start() {
        BPM = BPM / 10f;
        scrollSpeed = scrollSpeed / 1f;
    }

    void Update() {
        // If you want down scroll, use positive values
            gameObject.transform.position -= new Vector3(0f, -scrollSpeed * Time.deltaTime, 0f);
    }
}

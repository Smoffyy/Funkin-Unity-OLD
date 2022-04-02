using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float BPM;

    void Start() {
        BPM = BPM / 10f;
    }
    
    void Update() {
        transform.position -= new Vector3(0f, -BPM * Time.deltaTime, 0f);
    }   
}

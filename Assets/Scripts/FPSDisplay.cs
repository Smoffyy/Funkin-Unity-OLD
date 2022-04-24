using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    private float frequency = 1f;
    private float time;
    private int frameCount;

    void Update()
    {
        time += Time.deltaTime;
        frameCount++;
        if (time >= frequency)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = frameRate.ToString() + " FPS";
            time -= frequency;
            frameCount = 0;
        }
    }
}

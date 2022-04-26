using UnityEngine;

public class GameState : MonoBehaviour
{
    public AudioSource Instrumental;
    public AudioSource Vocals;
    public static GameState instance;
    public float scrollSpeed;
    public float BPM;

    void Start() {
        instance = this;
        Instrumental.Play();
        Vocals.Play();
        BPM = BPM / 10f;
        scrollSpeed = scrollSpeed / 1f;
    }

    void Update() {
         // If you want down scroll, use positive values
        // Refers to the game object
       if (gameObject.tag == "Charting") {
            transform.position -= new Vector3(0f, -scrollSpeed * Time.deltaTime, 0f);
        }
    }

    public void daNoteHit() {
        //Debug.Log("Note Hit");
    }
    public void daNoteMiss() {
        //Debug.Log("Note Miss");
    }
}

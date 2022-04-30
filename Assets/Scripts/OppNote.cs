using UnityEngine;

public class OppNote : MonoBehaviour
{
    public bool canBePressed;
    //public static OppNote instance;

    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ActiveOp")
        {
            canBePressed = true;
            gameObject.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.activeSelf)
        {
            canBePressed = false;
        }
    }
}

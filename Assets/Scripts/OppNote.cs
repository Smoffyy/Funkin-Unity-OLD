using UnityEngine;

public class OppNote : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public bool canBePressed;
    public Sprite invisibleSprite;
    //public static OppNote instance;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ActiveOp")
        {
            canBePressed = true;
            spriteRenderer.sprite = invisibleSprite;
            //gameObject.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        spriteRenderer.sprite = invisibleSprite;
        //gameObject.SetActive(false);
    }
}

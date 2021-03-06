using UnityEngine;

public class Controller : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite defaultSprite;
    public Sprite pressedSprite;
    public Sprite hitSprite;
    public KeyCode keyBind;
    public KeyCode altKeyBind;
    public static Controller instance;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        instance = this;
    }

    void Update()
    {
        // Keybind
        if (Input.GetKeyDown(keyBind))
        {
            spriteRenderer.sprite = pressedSprite;
        }
        if (Input.GetKeyUp(keyBind))
        {
            spriteRenderer.sprite = defaultSprite;
        }
        // Alt Keybind
        if (Input.GetKeyDown(altKeyBind))
        {
            spriteRenderer.sprite = pressedSprite;
        }
        if (Input.GetKeyUp(altKeyBind))
        {
            spriteRenderer.sprite = defaultSprite;
        }
    }

    public void daNoteHit()
    {   /*
        if (!Input.GetKeyDown(keyBind))
        {
              spriteRenderer.sprite = hitSprite;
        }

        if (!Input.GetKeyDown(altKeyBind))
        {
              spriteRenderer.sprite = hitSprite;
        }

        if (!Input.GetKey("1"))
        {
            spriteRenderer.sprite = hitSprite;
        } else
        {
            spriteRenderer.sprite = defaultSprite;
        }
        */
    }
    public void daNoteMiss()
    {
        spriteRenderer.sprite = defaultSprite;
    }
}


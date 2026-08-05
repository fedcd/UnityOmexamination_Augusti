using UnityEngine;

public class S
{
    
}


public class ChangeSprite : MonoBehaviour
{
    public Sprite nySprite;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.sprite = nySprite;
        }
    }
}

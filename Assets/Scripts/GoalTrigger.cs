using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void changeSprite()
    {
        if (spriteRenderer.sprite == sprite1)
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            spriteRenderer.sprite = sprite1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        changeSprite();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        changeSprite();
    }
}

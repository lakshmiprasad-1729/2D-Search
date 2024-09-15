using System;
using UnityEngine;

public class ReactOnTouch : MonoBehaviour
{
    private Color greenColor = new Color(0, 1, 0, 1);
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                spriteRenderer.color = greenColor;
                hit.collider.gameObject.SetActive(false);
            }
        }
    }
}

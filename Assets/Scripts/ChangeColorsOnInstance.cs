using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorsOnInstance : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
    
}

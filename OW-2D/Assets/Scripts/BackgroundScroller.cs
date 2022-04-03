using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(1f, 20f)]
    public float scrollSpeed = 10f;
    public float scrollOffset;
    Vector2 startPos;
    float newPos;


    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPos = Mathf.Repeat (Time.time * scrollSpeed, scrollOffset);
        transform.position = startPos + Vector2.down * newPos;
        Debug.Log("Pepe: " + newPos);
    }
}

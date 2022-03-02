using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHander : MonoBehaviour
{
    public Texture2D handCursor;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(handCursor, Vector2.zero, CursorMode.Auto);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableAspect : MonoBehaviour
{
    private Camera cam;

    private float width = 1080f;
    private float height = 1920f;

    private float pixelPerUnit = 200f;

    // Start is called before the first frame update
    void Start()
    {
        float aspect = (float)Screen.height / (float)Screen.width;
        float bgAspect = height / width;

        cam = GetComponent<Camera>();
        cam.orthographicSize = height / 2f / pixelPerUnit;

        if (bgAspect > aspect)
        {
            float bgScale = height / Screen.height;
            float camWidth = width / (Screen.width * bgScale);
            cam.rect = new Rect((1f - camWidth) / 2f, 0f, camWidth, 1f);
        } else
        {
            float bgScale = aspect / bgAspect;
            cam.orthographicSize *= bgScale;
            cam.rect = new Rect(0f, 0f, 1f, 1f);
        }
    }
}

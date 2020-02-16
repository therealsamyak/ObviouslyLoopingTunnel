using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour
{
    public Camera cam;
    public float firstFrame;
    public float zoomSpeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        cam.orthographicSize = (firstFrame + (zoomSpeed * Time.deltaTime));


    }
}

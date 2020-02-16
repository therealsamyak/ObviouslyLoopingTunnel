using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollableBackground : MonoBehaviour
{
    public float speed = 1f;
    public float acceleration = 1f;
    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        
        r = GetComponent<Renderer>();
        print(r);
    }

    float x = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
       
        r.material.mainTextureOffset = new Vector2(x, 0);
        x += Time.deltaTime * (speed + acceleration);
    }



}

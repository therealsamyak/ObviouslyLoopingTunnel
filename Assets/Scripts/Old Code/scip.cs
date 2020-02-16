using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scip : MonoBehaviour
{
    public float jumpForce;
    public float forwardVelocity;
    public float slerpAngleSpeed;
    private Rigidbody2D rigidBody;
    private float theta;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < -3)
        {
            if (grounded)
                jumpForce = 2000;
            rigidBody.velocity = new Vector2(0, 0);
            rigidBody.AddForce(Vector2.up * jumpForce);
                Debug.Log("JUMP!");
        }

        float newTheta = Mathf.Atan(rigidBody.velocity.y / forwardVelocity) * 180 / Mathf.PI;
        theta = Mathf.SmoothStep(theta, newTheta, slerpAngleSpeed);
        gameObject.transform.rotation = Quaternion.Euler(Vector3.forward * theta);

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Ground")
            {
                grounded = true;

            }
        }
    }

}

// void OnCollisionEnter2D()
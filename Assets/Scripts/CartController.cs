using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartController : MonoBehaviour
{
    public float jumpForce;
    public float forwardVelocity;
    public float slerpAngleSpeed;
    public GameObject TryAgain;
    public AudioClip clip;
    public GameObject BGM;
    public GameObject Explosion;
    public float ExplosionXPos;
    public float ExplosionYPos;
    private Rigidbody2D rb;
    //private UI_Manager UI_Manager;
    private float theta;
    MasterScript gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //UI_Manager = GameObject.FindObjectOfType<UI_Manager>();
        gm = GameObject.Find("GameManager").GetComponent<MasterScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < -4)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        float newTheta = Mathf.Atan(rb.velocity.y / forwardVelocity) * 180 / Mathf.PI;
        theta = Mathf.SmoothStep(theta, newTheta, slerpAngleSpeed);
        gameObject.transform.rotation = Quaternion.Euler(Vector3.forward * theta);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            BGM.SetActive(false);
            Destroy(gameObject);
            TryAgain.SetActive(true);

            Instantiate(Explosion, new Vector3(-5.139868f, -3.844588f, 0.04365403f), Quaternion.Euler(Vector3.forward * 1));

            
        }
    }

   
}


        
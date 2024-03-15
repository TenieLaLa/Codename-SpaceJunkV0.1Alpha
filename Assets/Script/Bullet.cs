using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
 
    


    void Start()
    {
          rb = GetComponent<Rigidbody2D>();
          rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // -----------HAZARDS--------------

        if (other.gameObject.CompareTag("Can"))
        {
            Debug.Log("Destruido!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Junk"))
        {
            Debug.Log("Destruido!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("TrafficLigth"))
        {
            Debug.Log("Destruido!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Hazard"))
        {
            Debug.Log("Destruido!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

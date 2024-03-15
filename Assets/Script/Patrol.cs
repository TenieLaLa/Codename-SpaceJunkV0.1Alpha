using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    //public GameObject SpacePatrol;
    //public GameObject SpacePatrolStop1;
    //public GameObject SpacePatrolStop2;
    //public GameObject SpacePatrolStop3;
    /*public void Stop1()
    {
        SpacePatrol.SetActive(false);
        SpacePatrolStop1.SetActive(true);

        if (SpacePatrolStop1.activeSelf)
        {
            Stop2();
        }
    }

    public void Stop2()
    {
        SpacePatrolStop1.SetActive(false);
        SpacePatrolStop2.SetActive(true);
    }

    public void Stop3()
    {
        SpacePatrolStop2.SetActive(false);
        SpacePatrolStop3.SetActive(true);
    }*/
   // public GameObject SpacePatrol;

    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(2, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Termina Juego");
        }
    }

}

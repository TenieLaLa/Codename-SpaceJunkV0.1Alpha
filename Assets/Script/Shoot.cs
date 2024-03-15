using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{

    public GameObject shootingPoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    public void UpdateBullet()
    {
        if (shootingPoint == null)
        {
            shootingPoint = GameObject.FindGameObjectWithTag("BeamPoint");
        }
        
        Instantiate(bulletPrefab, shootingPoint.transform.position, transform.rotation);
    }
}

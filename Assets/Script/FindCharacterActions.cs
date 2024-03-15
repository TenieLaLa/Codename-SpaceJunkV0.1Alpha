using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCharacterActions : MonoBehaviour
{
    public void FindButtonJump()
    {
        FindObjectOfType<PlayerMovement>().jumpButton();

    }

    public void FindBullet()
    {
        //FindAnyObjectByType<Shoot>().UpdateBullet();
    }
}

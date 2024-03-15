using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStars : MonoBehaviour
{
    public int coinValue = 5;

    private void OnTriggerEnter2D(Collider2D other)
     {
   
        if(other.gameObject.CompareTag("Player")) {
            Debug.Log("Punto obtenido");
            ScoreManager.instance.ChangeScore(coinValue);
            //ScoreManager.instance.ChangeScore(CoinValue);
        }
    }
}

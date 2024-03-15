using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null){
        instance = this;
    }
        
    }

    // Update is called once per frame
    public void ChangeScore(int CoinValue)
    {
        score += CoinValue;
        text.text = "" + score.ToString();
    }


    public void FinalScore(int CoinValue)
    {
        text.text = "" + score;
    }
}

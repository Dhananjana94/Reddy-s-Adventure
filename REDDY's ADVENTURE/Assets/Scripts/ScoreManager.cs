using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    public TextMeshProUGUI Marks;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) {

            instance = this;
        }
    }

    public void changeScore(int coinValue) {
        //get coin value as a parameter

        score += coinValue;
        Marks.text = "X" + score.ToString(); // add coin value after the 

    }
}

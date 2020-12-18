using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinValueAdd : MonoBehaviour
{
    public int CoinValue = 1;
    public GameObject soundManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {

            ScoreManager.instance.changeScore(CoinValue);

            soundManager.GetComponent<coinSound>().PlayCoinSound();
        }
    }
}

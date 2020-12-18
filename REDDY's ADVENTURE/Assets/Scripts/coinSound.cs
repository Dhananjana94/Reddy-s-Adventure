using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSound : MonoBehaviour
    
{
    public AudioSource CoinSound;

    public void PlayCoinSound() {

        CoinSound.Play();
    }
}

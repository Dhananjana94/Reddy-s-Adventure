using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Settings : MonoBehaviour
{

    public AudioMixer audioMixer;
    

    public void SetVolume(float volume) {

        audioMixer.SetFloat("Volume",volume); //use same name mention in exposed parameter, in here = "Volume"
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);  
    }
}

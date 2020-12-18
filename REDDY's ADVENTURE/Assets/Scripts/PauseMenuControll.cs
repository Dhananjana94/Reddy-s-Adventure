using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuControll : MonoBehaviour
{

    public GameObject pausemenu;
    public GameObject SettingPannel;
    // public GameObject gameOverPnl;
    public void pausebtn()
    {
        pausemenu.GetComponent<Animator>().SetTrigger("pop");

       // pausemenu.SetActive(true);
        

    }

    public void Resume() {

        pausemenu.GetComponent<Animator>().SetTrigger("pop");
        //Time.timeScale = 1f;
    }

    public void setting()
    {

        SettingPannel.GetComponent<Animator>().SetTrigger("SetPop");


    }


}

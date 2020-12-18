using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControll : MonoBehaviour
{

    public GameObject SettingPannel;
    public GameObject UpPannel;
  

    public void play()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void setting() {

        SettingPannel.GetComponent<Animator>().SetTrigger("pop");

       
    }

    public void upbtn()
    {

        UpPannel.GetComponent<Animator>().SetTrigger("pop");


    }

  

}

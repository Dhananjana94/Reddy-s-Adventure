using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{


    [SerializeField]
    Image lifeFilled;

    float life = 1f; //life between 0 and 1, 0 mean dead;
   // public GameObject box;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("enemy"))
        {

            RemoveLife();
        }

    }

    public void AddLife()
    {
        if (life < 1f)
        {

            life += 0.1f;
            lifeFilled.fillAmount = life;
        }

       
    }


     void RemoveLife()
    {
        //Debug.Log("heart brak");
        if (life > 0f)
        {

            life -= 0.1f;
            lifeFilled.fillAmount = life;
        }

        if(life <= 0f)
        {
            FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<PlayerMovement>().enabled = false;
        }
    }
}

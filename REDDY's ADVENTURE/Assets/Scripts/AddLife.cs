using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddLife : MonoBehaviour
{
    public GameObject box;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            box.GetComponent<Animator>().SetTrigger("open");
            FindObjectOfType<Health>().AddLife();

            Destroy(gameObject, 1f); //destroy object after delay
        }


    }

   

}

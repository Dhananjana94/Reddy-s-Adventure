using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{

    public AIPath aiPath;

    // Update is called once per frame
    void Update()
    {
        //Desire  veloocity mean enemy would like to travel
        if (aiPath.desiredVelocity.x >= 0.01f) {

            transform.localScale = new Vector3(-1f, 1f, 1f); // enemy travel to the right
        }
        else if (aiPath.desiredVelocity.x <= -0.01f) {

            transform.localScale = new Vector3(1f,1f,1f); //when enemy travel to the left 
        }
    }
}

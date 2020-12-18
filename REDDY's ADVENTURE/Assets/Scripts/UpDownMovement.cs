using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
    private Vector3 PosA; //this posA and posB are the position that object move
    private Vector3 PosB;

    private Vector3 nextPos; //nextPos is equal to posA or posB
 
    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform ChildTransform;

    [SerializeField]
    private Transform TransformB;


    private void Start()
    {
        PosA = ChildTransform.localPosition; // position A
        PosB = TransformB.localPosition; // position B
        nextPos = PosB; 
    }

    // Update is called once per frame

    void Update()
    {
        Move();
    }

    private void Move()
    {
        ChildTransform.localPosition = Vector3.MoveTowards(ChildTransform.localPosition, nextPos, speed * Time.deltaTime); //transform object current position to next position

        if (Vector3.Distance(ChildTransform.localPosition,nextPos) <= 0.1 ) {

            ChangeDestination(); //if obect position not equal to current position move object up and down
        }
    }

    private void ChangeDestination() {

        nextPos = nextPos != PosA ? PosA : PosB;
    }
}

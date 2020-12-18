using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float speed = 100f;
    public float nextWaypointDistance = 3f;
    Path path;
    int currentWayPoint = 0;
    bool reachEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // find the component
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        //Generate path

        seeker.StartPath(rb.position, target.position, OnPathComplete);
    }

    void OnPathComplete(Path p) {

        if (!p.error) {

            path = p;
            currentWayPoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //fixed update call only fix number of time
        if (path == null)
            return;

        if (currentWayPoint >= path.vectorPath.Count)
        {

            reachEndOfPath = true;
            return;
        }

        else {

            reachEndOfPath = false;

        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWayPoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime; //not depending on frame rate

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPoint]);

        if (distance < nextWaypointDistance) {

            currentWayPoint++;
        }
    }
}

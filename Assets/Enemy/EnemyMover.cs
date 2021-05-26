using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private List<Waypoint> path = new List<Waypoint>();
    [SerializeField] private float waitTime = 1f;

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;

            // Ends stuff here, goes back to start to finish it and
            // returns after 1 second to continue here.
            // Loops until every waypoint has been visited.
            yield return new WaitForSeconds(waitTime);
        }
    }
}

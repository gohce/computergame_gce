using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoint;

    public Animator animator;
    public float moveSpeed = lf;
    private int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoint[waypointIndex].transform.position;
    }

    private void followPath()
    {
        if (waypointIndex <= waypoint.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
        }

        if (transform.position == waypoint[waypointIndex].transform.position)
        {
            waypoint += 1;
        }

        if (waypointIndex == waypoint.Length)
        {
            waypointIndex = 0;
        }
    }

    private void checkAnimDirection()
    {
        if (waypointIndex == 1)
            animator.SetInteger("moveDir", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

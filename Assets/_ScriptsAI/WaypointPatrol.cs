using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPatrol : MonoBehaviour
{
    public float Speed = 2;
    public Transform[] Waypoints;
    public bool Move2D;
    public float MinDistance=0.01f;

    private int _currentWaypointIndex;
    Transform CurrentWaypoint => Waypoints[_currentWaypointIndex];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CloseToWaypoint())
            ChangeWaypoint();

        Move();
    }

    private bool CloseToWaypoint()
    {
        return Vector3.Distance(transform.position, CurrentWaypoint.position) < MinDistance;
    }
    private void ChangeWaypoint()
    {
        _currentWaypointIndex++;

        _currentWaypointIndex = _currentWaypointIndex % Waypoints.Length;
        /* less elegant but same result
        if (_currentWaypointIndex >= Waypoints.Length)
            _currentWaypointIndex = 0;
        */
    }

    private void Move()
    {
        Vector3 target = CurrentWaypoint.position;
        if(Move2D)
            target.y = transform.position.y; 
        transform.LookAt(target);
        transform.Translate(transform.forward * Speed * Time.deltaTime, Space.World);
    }
}

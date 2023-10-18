using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform user;
    private NavMeshAgent enemy;
    public bool userDetect;

    void Start()
    {
        enemy = GetComponet<NavMeshAgent>();//modo dinamico
    }

    // Update is called once per frame
    void Update()
    {
        if (userDetect) 
        enemy.destinatiom=user.position;
    }
}

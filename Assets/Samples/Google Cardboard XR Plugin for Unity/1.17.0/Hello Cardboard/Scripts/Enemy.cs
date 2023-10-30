using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    //public bool userDetect;
    public Transform user;
    private NavMeshAgent enemy;
    // lo que se recomienda es dejarlo en privado
    //public Animator EnemyAnimator;
    //private void OnTriggerEnter(Collider other)
    //{
    //    userDetect = true;
    //}
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        //EnemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.destination = user.position;
    }
}
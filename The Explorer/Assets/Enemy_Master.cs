using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Master : MonoBehaviour
{
    public Animator Enemy;
    public GameObject Player;
    public float Distance;

    public bool IsChasing;

    public NavMeshAgent _agent;

    public object SetBool { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if(Distance <=30)
        {
            IsChasing = true;
            Enemy.SetBool("IsChasing", true);
        }
        if(Distance > 30f)
        {
            IsChasing = false;
            Enemy.SetBool("IsChasing", false);
        }

        if (Distance <= 5)
        {
            IsChasing = true;
            Enemy.SetBool("IsChasing", false);
            Enemy.SetTrigger("Attacking");
        }
        if (IsChasing)
        {

            _agent.isStopped = false;
            _agent.SetDestination(Player.transform.position);

        }
        if(!IsChasing)
        {
            _agent.isStopped = true;
        }

      
    }   
}

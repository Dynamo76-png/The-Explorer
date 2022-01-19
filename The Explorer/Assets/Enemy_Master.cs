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
        }
        if(Distance > 30f)
        {
            IsChasing = false;
        }

        if(IsChasing)
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

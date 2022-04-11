using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            agent.SetDestination(target.position);
        }
    }
}

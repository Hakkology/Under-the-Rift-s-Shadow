using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PeasentAIScript : MonoBehaviour
{   
    public List<GameObject> targets = new List<GameObject>();
    NavMeshAgent agent;
    public NPCScript npc;

    float DestinationReachedThreshold = 4;


    // Start is called before the first frame update
    void Start()
    {
        npc.isWalking = true;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        int workChoice = Random.Range(0, targets.Count);
        agent.SetDestination(targets[workChoice].transform.position);
        if (Vector3.Distance(transform.position, targets[workChoice].transform.position) < DestinationReachedThreshold)
        {
            workChoice = Random.Range(0, targets.Count);
            agent.SetDestination(targets[workChoice].transform.position);
        }
    }
}



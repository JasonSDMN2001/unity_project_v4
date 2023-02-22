using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentpatrol : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField]private Transform[] points;
    int pointIndex;
    Animator animator;
    bool walking;
    bool waiting;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        pointIndex = -1;
        walking = false;
        waiting = false;   
        animator.SetBool("Walking", false);
        StartCoroutine( NextPoint());    
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance && !waiting && agent.pathStatus==NavMeshPathStatus.PathComplete)
        {
            StartCoroutine(NextPoint());
        }
    }
    IEnumerator NextPoint()
    {   
        walking = false;
        waiting=true;
        animator.SetBool("Walking", walking);

        float randomSeconds = Random.Range(1, 4);
        yield return new WaitForSeconds(randomSeconds);

        //yield return null;

        pointIndex = (pointIndex + 1) % points.Length;
        agent.SetDestination(points[pointIndex].position);

        walking = true;
        waiting = false;
        animator.SetBool("Walking", walking);
        yield return null;
    }
}

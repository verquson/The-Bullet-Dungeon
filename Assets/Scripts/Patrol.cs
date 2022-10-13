using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;


    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // palaa takaisin jos pointteja ei ole asetettu.
        if (points.Length == 0)
            return;

        // asettaa agentin menem‰‰n seuraavaksi valittuun kohteeseen
        agent.destination = points[destPoint].position;

        // valitsee seuraavan pointin ja matkan. jos ei enemp‰‰ pointteja niin alkaa alusta.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        // p‰‰tt‰‰ pointin kun p‰‰set l‰helle toista.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}

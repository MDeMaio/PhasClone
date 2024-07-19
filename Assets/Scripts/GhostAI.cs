using UnityEngine;
using UnityEngine.AI;

public class GhostAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;

    private void Update() {
        if (target != null){
            agent.SetDestination(target.position); // Moves ghost to target and uses navmesh to avoid walls
        }
    }
}
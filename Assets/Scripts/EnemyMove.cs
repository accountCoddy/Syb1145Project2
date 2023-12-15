using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : StateMachineBehaviour
{
    private PlayerMove _player;
    private NavMeshAgent _agent;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _player = FindObjectOfType<PlayerMove>();
        _agent = animator.GetComponent<NavMeshAgent>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _agent.SetDestination(_player.transform.position);

        float distance = Vector3.Distance(_player.transform.position, animator.transform.position);

        if (distance > 10)
            animator.SetBool("Move", false);
    }
}

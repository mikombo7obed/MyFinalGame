using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour
{

	public Animator animator;

	NavMeshAgent agent;
	CharacterCombat combat;

	protected virtual void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		combat = GetComponent<CharacterCombat>();
		combat.OnAttack += OnAttack;
	}

	protected virtual void Update() 
	{
		animator.SetFloat("Speed Percent", agent.velocity.magnitude / agent.speed, .1f, Time.deltaTime);
	}

	protected virtual void OnAttack()
	{
		animator.SetTrigger("Attack");
	}
}
using UnityEngine;

public class LinkedAnim : StateMachineBehaviour
{
	public Animator Anim;

	public string trigger;

	public string Tag;

	public bool OneShot;

	public bool Done;

	private void Awake()
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}

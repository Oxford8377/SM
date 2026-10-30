using UnityEngine;

public class PlaySound : StateMachineBehaviour
{
	public AudioSource Sound;

	public string Tag;

	private void Awake()
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}

using Rewired;
using UnityEngine;
using UnityEngine.Events;

public class ButtonEventWizard : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public string[] Button;

	public bool AnimatorIntChanger;

	public Animator Anim;

	public string AnimInt;

	public string[] AnimString;

	public int minInt;

	public int maxInt;

	public int Tab;

	[SerializeField]
	private UnityEvent m_Button0;

	[SerializeField]
	private UnityEvent m_Button1;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AnimIntSubtract()
	{
	}

	public void AnimIntAdd()
	{
	}

	public void AnimTabPrev()
	{
	}

	public void AnimTabNext()
	{
	}
}

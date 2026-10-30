using Rewired;
using UnityEngine;
using UnityEngine.Events;

public class OptionsTabs : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public string[] Button;

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
}

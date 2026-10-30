using Rewired;
using SonicBloom.Koreo;
using UnityEngine;

public class SkipIntro : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public bool forwarding;

	public AudioSource Song;

	public AudioSource SongFree;

	public float Speed;

	public Animator FFWScreen;

	public bool Done;

	public bool NoFreeMode;

	public static bool Alive;

	public GameObject Pauser;

	[EventID]
	public string Checkpoint;

	private void Start()
	{
	}

	private void On_Checkpoint(KoreographyEvent evt)
	{
	}

	private void Update()
	{
	}
}

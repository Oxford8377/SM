using Rewired;
using SonicBloom.Koreo;
using UnityEngine;

public class MusicBox : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public string Sticker;

	public bool active;

	public Animator Up;

	public Animator Down;

	public Animator Left;

	public Animator Right;

	public int points;

	public int pointsNeeded;

	public AudioSource Ups;

	public AudioSource Downs;

	public AudioSource Lefts;

	public AudioSource Rights;

	public bool busy;

	public Animator musicbox;

	public AudioSource good;

	public AudioSource bad;

	public Animator player1;

	public GameObject ItemGet;

	public GameObject Close;

	public GameObject Lock;

	public AudioSource music;

	public Animator Tag;

	[EventID]
	public string Up_note;

	[EventID]
	public string Down_note;

	[EventID]
	public string Left_note;

	[EventID]
	public string Right_note;

	[EventID]
	public string Up_P;

	[EventID]
	public string Down_P;

	[EventID]
	public string Left_P;

	[EventID]
	public string Right_P;

	[EventID]
	public string End;

	[EventID]
	public string StartUp;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void On_Start(KoreographyEvent evt)
	{
	}

	private void On_End(KoreographyEvent evt)
	{
	}

	private void On_Up(KoreographyEvent evt)
	{
	}

	private void On_Down(KoreographyEvent evt)
	{
	}

	private void On_Left(KoreographyEvent evt)
	{
	}

	private void On_Right(KoreographyEvent evt)
	{
	}

	private void On_UpP(KoreographyEvent evt)
	{
	}

	private void On_DownP(KoreographyEvent evt)
	{
	}

	private void On_LeftP(KoreographyEvent evt)
	{
	}

	private void On_RightP(KoreographyEvent evt)
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class testnpc : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSwitchCam_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public testnpc _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSwitchCam_003Ed__54(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int playerId;

	private Player player;

	private CharacterController cc;

	public string Facing;

	public GameObject textBox;

	public GameObject Choice;

	public bool nearby;

	public GameObject playerObj;

	public Transform MelTr;

	public Animator Player;

	public Animator doorfade;

	public bool NeedKBToPass;

	public bool hasKeyboard;

	public bool Door;

	public bool SceneDoor;

	public Vector3 TakeTo;

	public GameObject CurrentCam;

	public GameObject NewCam;

	public GameObject CurrentDoor;

	public GameObject NextDoor;

	public int CamAngle;

	public int DoorDir;

	public GameObject doorBlack;

	public bool CamReady;

	public bool Instant;

	public bool active;

	public bool InstaCutscene;

	public GameObject Cutscene;

	public bool Important;

	public GameObject Notif;

	public bool Person;

	public Animator NPC;

	public AudioSource bgmusic;

	public bool IsCutscene;

	public bool readytogo;

	public string NextScene;

	public bool musicbox;

	public Animator MusicBox;

	public bool done;

	public GameObject Lock;

	public GameObject Close;

	public GameObject ItemGet;

	public GameObject StickerBook;

	public Collider collo;

	public bool NeedsCollo;

	public bool SpecialNPC;

	public bool flip;

	public SpriteRenderer Character;

	public Animator MelodiiActor;

	public bool InMenu;

	public static bool MusicTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartMusicBox()
	{
	}

	[IteratorStateMachine(typeof(_003CSwitchCam_003Ed__54))]
	private IEnumerator SwitchCam()
	{
		return null;
	}

	public void Done()
	{
	}

	public void ExitDoor()
	{
	}

	public void OnTriggerEnter(Collider coll)
	{
	}

	public void OnTriggerExit(Collider coll)
	{
	}
}

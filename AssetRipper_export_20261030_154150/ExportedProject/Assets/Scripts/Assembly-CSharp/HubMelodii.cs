using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class HubMelodii : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CQuitGame_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CQuitGame_003Ed__48(int _003C_003E1__state)
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

	public static bool Debug;

	public bool DebugMode;

	private Rigidbody rb;

	private Vector3 movement;

	public float speed;

	public float speedOG;

	public float Runspeed;

	public float RunspeedOG;

	public float acceleration;

	public float maxSpeed;

	private float moveLimiter;

	public GameObject notifBox;

	public Animator self;

	public bool moving;

	public bool strafe;

	public static bool hasKeyboard;

	public static bool canMove;

	public AudioSource music;

	public bool SCam;

	public bool FCam;

	public Camera stillcam;

	public Camera followcam;

	public GameObject Stopper;

	public static bool InMenu;

	public bool Cutscene;

	public GameObject StickerBook;

	public GameObject Self;

	public bool NoAnims;

	public bool NotifTime;

	public bool gamePaused;

	public GameObject PauseMenu;

	public bool pressUp;

	public bool pressDown;

	public bool pressLeft;

	public bool pressRight;

	public int HorAxis;

	public int VerAxis;

	public int hasKB;

	private void Start()
	{
	}

	private void StillCam()
	{
	}

	private void FollowCam()
	{
	}

	public void EmergencyCanMove()
	{
	}

	public void Resume()
	{
	}

	public void ResumeToStickerBook()
	{
	}

	public void Quit()
	{
	}

	[IteratorStateMachine(typeof(_003CQuitGame_003Ed__48))]
	private IEnumerator QuitGame()
	{
		return null;
	}

	public void OpenStickerBook()
	{
	}

	private void ItemGet()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Stop()
	{
	}

	public void NotifTimeOn()
	{
	}

	public void NotifTimeGone()
	{
	}
}

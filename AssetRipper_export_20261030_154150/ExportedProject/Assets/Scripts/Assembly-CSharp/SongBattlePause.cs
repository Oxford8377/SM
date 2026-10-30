using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.Video;

public class SongBattlePause : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CResumeGame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SongBattlePause _003C_003E4__this;

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
		public _003CResumeGame_003Ed__15(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CQuitGame_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CQuitGame_003Ed__18(int _003C_003E1__state)
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

	public AudioSource[] AudioSources;

	public VideoPlayer[] VideoPlayers;

	public GameObject Menu;

	public static bool gamePaused;

	public static bool CanPause;

	public static bool songOver;

	public bool InOptions;

	public static int LofiWarning;

	public static bool CanSkipIntro;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Resume()
	{
	}

	[IteratorStateMachine(typeof(_003CResumeGame_003Ed__15))]
	private IEnumerator ResumeGame()
	{
		return null;
	}

	public void Retry()
	{
	}

	public void Quit()
	{
	}

	[IteratorStateMachine(typeof(_003CQuitGame_003Ed__18))]
	private IEnumerator QuitGame()
	{
		return null;
	}

	public void OptionsOpen()
	{
	}

	public void OptionsClosed()
	{
	}
}

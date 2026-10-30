using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class noteamongus : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChecker_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public noteamongus _003C_003E4__this;

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
		public _003CChecker_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CPinkPoints_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public noteamongus _003C_003E4__this;

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
		public _003CPinkPoints_003Ed__42(int _003C_003E1__state)
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

	public string Note;

	public string Special;

	public static string Difficulty;

	public string CurrentDifficulty;

	public float tempo;

	public static float Tempo;

	public bool TempoNeedsHelp;

	public static bool DiffSet;

	public static bool NoMoreA;

	public static bool NoMoreB;

	public static bool NoMoreX;

	public static bool NoMoreY;

	public static bool NoMoreL;

	public static bool NoMoreR;

	public static bool NoMoreUp;

	public static bool NoMoreDown;

	public static bool NoMoreLeft;

	public static bool NoMoreRight;

	public bool NoMore;

	public static int CloseCount;

	public bool closecounted;

	public bool trigger;

	public bool mentor;

	public bool pink;

	public bool counted;

	public bool onbeat;

	public GameObject Ghost;

	public bool ghost;

	private static Animator anim;

	public bool usePinkPointsPlayer;

	[SerializeField]
	private UnityEvent m_BeatPoints;

	[SerializeField]
	private UnityEvent m_RemovePoints;

	[SerializeField]
	private UnityEvent m_AdjustSlider;

	[SerializeField]
	private UnityEvent m_PinkPointsPlayer;

	[SerializeField]
	private UnityEvent m_BeatPointsMentor;

	[SerializeField]
	private UnityEvent m_PinkPointsMentor;

	private void Start()
	{
	}

	public void RevealGhosts()
	{
	}

	public void KillGhosts()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[IteratorStateMachine(typeof(_003CChecker_003Ed__41))]
	private IEnumerator Checker()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPinkPoints_003Ed__42))]
	private IEnumerator PinkPoints()
	{
		return null;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerIco : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWait_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerIco _003C_003E4__this;

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
		public _003CWait_003Ed__24(int _003C_003E1__state)
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

	private bool active;

	public GameObject note_A;

	public GameObject note1a;

	public AudioSource voice;

	public AudioClip cut1;

	public AudioClip cut2;

	public float line;

	public GUI scoreText;

	public float rhyths;

	public bool onbackbeat;

	public bool onbeat;

	public bool onstarbeat;

	public bool offbeat;

	public bool offbackbeat;

	public bool offstarbeat;

	public bool offanybeat;

	public bool onanybeat;

	public bool good;

	public int funk;

	public AudioClip good1;

	public AudioClip bad1;

	public ParticleSystem burstin;

	private Animator anim;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__24))]
	private IEnumerator Wait()
	{
		return null;
	}

	private void Update()
	{
	}

	public void AddPoints(int points)
	{
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
	}

	public void OnTriggerExit2D(Collider2D coll)
	{
	}
}

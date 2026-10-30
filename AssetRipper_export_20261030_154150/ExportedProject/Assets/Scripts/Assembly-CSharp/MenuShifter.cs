using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuShifter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEvSysFix_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuShifter _003C_003E4__this;

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
		public _003CEvSysFix_003Ed__16(int _003C_003E1__state)
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

	public GameObject[] Tabs;

	public GameObject[] Tabsel;

	public int Tab;

	public int TabAmount;

	public GameObject CurrentTab;

	public GameObject[] TabIcos;

	public EventSystem m_EventSystem;

	public AudioSource Music;

	public Animator Menu;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ChangeTab()
	{
	}

	private void LoadTab()
	{
	}

	[IteratorStateMachine(typeof(_003CEvSysFix_003Ed__16))]
	private IEnumerator EvSysFix()
	{
		return null;
	}
}

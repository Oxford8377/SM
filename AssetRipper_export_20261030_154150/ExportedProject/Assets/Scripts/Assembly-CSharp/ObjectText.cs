using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectText : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowButton_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ObjectText _003C_003E4__this;

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
		public _003CShowButton_003Ed__49(int _003C_003E1__state)
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
	private sealed class _003CTypeText_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ObjectText _003C_003E4__this;

		private char[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private char _003Cletter_003E5__4;

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
		public _003CTypeText_003Ed__50(int _003C_003E1__state)
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

	public string emotion;

	public string direction;

	public bool HasCommand;

	public bool HasNoIcon;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public string NextScene;

	public float letPause;

	public float letPauseOrigin;

	public float spacePause;

	public float puncPause;

	public float elipPause;

	public string message;

	public string FinalText;

	public TextMeshProUGUI Phrase;

	public GameObject choice;

	public Animator speakerIco;

	public Animator playerObj;

	public bool ready;

	public AudioSource voice;

	public float line;

	public GameObject close;

	public GameObject textBox;

	public bool lastCharPunctuation;

	public char Letter;

	private char charComma;

	private char charPeriod;

	private char charExclam;

	private char charQmark;

	private char charElipse;

	private char charEmpty;

	public bool CanSkip;

	public bool IsCutscene;

	public GameObject Cutscene;

	public bool Person;

	public Animator NPC;

	public static bool amorgos;

	public bool NotStupid;

	public bool Choice;

	public bool MusicBox;

	public bool Example;

	public bool Example2;

	public bool HasPrompt;

	public GameObject ButtPrompt;

	public float PromptTime;

	public GameObject Extra;

	public PlayableDirector Timeline;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CShowButton_003Ed__49))]
	private IEnumerator ShowButton()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTypeText_003Ed__50))]
	private IEnumerator TypeText()
	{
		return null;
	}

	private void Update()
	{
	}
}

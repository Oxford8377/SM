using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[RequireComponent(typeof(Selectable))]
	[AddComponentMenu(null)]
	public class UIButtonKeyTrigger : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSimulateButtonClick_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButtonKeyTrigger _003C_003E4__this;

			private float _003CtimeLeft_003E5__2;

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
			public _003CSimulateButtonClick_003Ed__15(int _003C_003E1__state)
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

		[Tooltip("Trigger the selectable when this key is pressed.")]
		public KeyCode key;

		[Tooltip("Trigger the selectable when this input button is pressed.")]
		public string buttonName;

		[Tooltip("Trigger if any key, input button, or mouse button is pressed.")]
		public bool anyKeyOrButton;

		[Tooltip("Ignore trigger key/button if UI button is being clicked Event System's Submit input. Prevents unintentional double clicks. For this checkbox to work, you must set the Input Device Manager component's Submit input to the same inputs as the EventSystem's Submit.")]
		public bool skipIfBeingClickedBySubmit;

		[Tooltip("Visually show UI Button in pressed state when triggered.")]
		public bool simulateButtonClick;

		[Tooltip("Show pressed state for this duration in seconds.")]
		public float simulateButtonDownDuration;

		private Selectable m_selectable;

		public static bool monitorInput;

		protected Selectable selectable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected void Update()
		{
		}

		protected virtual bool IsBeingClickedBySubmit()
		{
			return false;
		}

		protected virtual void Click()
		{
		}

		[IteratorStateMachine(typeof(_003CSimulateButtonClick_003Ed__15))]
		protected IEnumerator SimulateButtonClick()
		{
			return null;
		}
	}
}

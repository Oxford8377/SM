using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class UIShowHideController
	{
		public enum TransitionMode
		{
			State = 0,
			Trigger = 1
		}

		public enum State
		{
			Undefined = 0,
			Showing = 1,
			Shown = 2,
			Hiding = 3,
			Hidden = 4
		}

		[CompilerGenerated]
		private sealed class _003CWaitForAnimationState_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIShowHideController _003C_003E4__this;

			public State stateWhenEnd;

			public State stateWhenBegin;

			public string stateName;

			public bool wait;

			public bool panelActive;

			public bool pauseAfterAnimation;

			public Action callback;

			private float _003Ctimeout_003E5__2;

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
			public _003CWaitForAnimationState_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CWaitForAnimationTrigger_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIShowHideController _003C_003E4__this;

			public State stateWhenEnd;

			public State stateWhenBegin;

			public bool panelActive;

			public string triggerName;

			public bool wait;

			public bool pauseAfterAnimation;

			public Action callback;

			private float _003Ctimeout_003E5__2;

			private int _003CgoalHashID_003E5__3;

			private int _003ColdHashId_003E5__4;

			private int _003CcurrentHashID_003E5__5;

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
			public _003CWaitForAnimationTrigger_003Ed__23(int _003C_003E1__state)
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

		public static float maxWaitDuration;

		private TransitionMode m_transitionMode;

		private Animator m_animator;

		private bool m_lookedForAnimator;

		private Coroutine m_animCoroutine;

		public Component panel { get; set; }

		public State state { get; set; }

		public bool debug { get; set; }

		public UIShowHideController(GameObject gameObjectToControl, Component panelToControl, TransitionMode animationMode = TransitionMode.Trigger, bool debug = false)
		{
		}

		public void Show(string showState, bool pauseAfterAnimation, Action callback, bool wait = true)
		{
		}

		public void Hide(string hideState, Action callback)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForAnimationState_003Ed__22))]
		private IEnumerator WaitForAnimationState(State stateWhenBegin, State stateWhenEnd, string stateName, bool pauseAfterAnimation, bool panelActive, bool wait, Action callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitForAnimationTrigger_003Ed__23))]
		private IEnumerator WaitForAnimationTrigger(State stateWhenBegin, State stateWhenEnd, string triggerName, bool pauseAfterAnimation, bool panelActive, bool wait, Action callback)
		{
			return null;
		}

		private void CheckAnimatorModeAndTimescale(string triggerName)
		{
		}

		private void CancelCurrentAnim()
		{
		}

		public void ClearTrigger(string triggerName)
		{
		}

		private bool CanTriggerAnimation(string stateName)
		{
			return false;
		}

		private bool HasAnimator()
		{
			return false;
		}
	}
}

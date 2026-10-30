using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers
{
	public class UIAnimatorMonitor
	{
		[CompilerGenerated]
		private sealed class _003CWaitForAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIAnimatorMonitor _003C_003E4__this;

			public string triggerName;

			public bool wait;

			public Action callback;

			private float _003Ctimeout_003E5__2;

			private int _003CgoalHashID_003E5__3;

			private int _003ColdHashId_003E5__4;

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
			public _003CWaitForAnimation_003Ed__13(int _003C_003E1__state)
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

		public static float MaxWaitDuration;

		private MonoBehaviour m_target;

		private bool m_lookedForAnimator;

		private Animator m_animator;

		private Animation m_animation;

		private Coroutine m_coroutine;

		public string currentTrigger { get; private set; }

		public UIAnimatorMonitor(GameObject target)
		{
		}

		public UIAnimatorMonitor(MonoBehaviour target)
		{
		}

		public void SetTrigger(string triggerName, Action callback, bool wait = true)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForAnimation_003Ed__13))]
		private IEnumerator WaitForAnimation(string triggerName, Action callback, bool wait)
		{
			return null;
		}

		private bool HasAnimator()
		{
			return false;
		}

		private bool IsAnimatorValid()
		{
			return false;
		}

		private void CheckAnimatorModeAndTimescale(string triggerName)
		{
		}

		public void CancelCurrentAnimation()
		{
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUITimer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityUITimer _003C_003E4__this;

			public float duration;

			public Action timeoutHandler;

			private float _003CendTime_003E5__2;

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
			public _003CCountdown_003Ed__4(int _003C_003E1__state)
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

		private Slider slider;

		private float startTime;

		public virtual void Awake()
		{
		}

		public virtual void StartCountdown(float duration, Action timeoutHandler)
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__4))]
		private IEnumerator Countdown(float duration, Action timeoutHandler)
		{
			return null;
		}

		public void SkipTime(float amountToSkip)
		{
		}

		public virtual void UpdateTimeLeft(float normalizedTimeLeft)
		{
		}

		public virtual void OnDisable()
		{
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandAnimatorPlayWait : SequencerCommand
	{
		[CompilerGenerated]
		private sealed class _003CMonitorState_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SequencerCommandAnimatorPlayWait _003C_003E4__this;

			public Animator animator;

			public string stateName;

			private float _003CmaxStartTime_003E5__2;

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
			public _003CMonitorState_003Ed__2(int _003C_003E1__state)
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

		private const float maxDurationToWaitForStateStart = 1f;

		public void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CMonitorState_003Ed__2))]
		private IEnumerator MonitorState(Animator animator, string stateName)
		{
			return null;
		}

		private bool CheckIsInState(Animator animator, string stateName, out AnimatorStateInfo animatorStateInfo)
		{
			animatorStateInfo = default(AnimatorStateInfo);
			return false;
		}
	}
}

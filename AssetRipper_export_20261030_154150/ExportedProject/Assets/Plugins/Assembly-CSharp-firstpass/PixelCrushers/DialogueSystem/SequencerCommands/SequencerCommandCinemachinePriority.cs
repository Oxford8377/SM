using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandCinemachinePriority : SequencerCommand
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SequencerCommandCinemachinePriority _003C_003E4__this;

			private CinemachineBrain _003CcinemachineBrain_003E5__2;

			private CinemachineBlendDefinition.Style _003CpreviousBlendStyle_003E5__3;

			private float _003CpreviousBlendTime_003E5__4;

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
			public _003CStart_003Ed__1(int _003C_003E1__state)
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

		private static bool hasRecordedBlendMode;

		[IteratorStateMachine(typeof(_003CStart_003Ed__1))]
		public IEnumerator Start()
		{
			return null;
		}
	}
}

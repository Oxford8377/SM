using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandCinemachineZoom : SequencerCommand
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SequencerCommandCinemachineZoom _003C_003E4__this;

			private CinemachineVirtualCamera _003Cvcam_003E5__2;

			private float _003Czoom_003E5__3;

			private float _003Cduration_003E5__4;

			private float _003CoriginalSize_003E5__5;

			private float _003Celapsed_003E5__6;

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
			public _003CStart_003Ed__0(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CStart_003Ed__0))]
		protected virtual IEnumerator Start()
		{
			return null;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[AddComponentMenu(null)]
	public class SlideEffect : GUIEffect
	{
		public enum SlideDirection
		{
			FromBottom = 0,
			FromTop = 1,
			FromLeft = 2,
			FromRight = 3
		}

		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SlideEffect _003C_003E4__this;

			private Rect _003Crect_003E5__2;

			private float _003CstartTime_003E5__3;

			private float _003CendTime_003E5__4;

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
			public _003CPlay_003Ed__4(int _003C_003E1__state)
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

		public SlideDirection direction;

		public float duration;

		private GUIControl control;

		[IteratorStateMachine(typeof(_003CPlay_003Ed__4))]
		public override IEnumerator Play()
		{
			return null;
		}
	}
}

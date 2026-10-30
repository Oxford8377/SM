using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PixelCrushers.DialogueSystem
{
	public static class DialogueTime
	{
		public enum TimeMode
		{
			Realtime = 0,
			Gameplay = 1,
			Custom = 2
		}

		[CompilerGenerated]
		private sealed class _003CWaitForSeconds_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float seconds;

			private float _003Cstart_003E5__2;

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
			public _003CWaitForSeconds_003Ed__26(int _003C_003E1__state)
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

		private static TimeMode m_mode;

		private static float m_customTime;

		private static float m_customDeltaTime;

		private static bool m_isPaused;

		private static float s_realtimeWhenPaused;

		private static float s_totalRealtimePaused;

		public static TimeMode mode
		{
			get
			{
				return default(TimeMode);
			}
			set
			{
			}
		}

		public static float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float deltaTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static bool isPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static TimeMode Mode
		{
			get
			{
				return default(TimeMode);
			}
			set
			{
			}
		}

		public static bool IsPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		static DialogueTime()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForSeconds_003Ed__26))]
		public static IEnumerator WaitForSeconds(float seconds)
		{
			return null;
		}
	}
}

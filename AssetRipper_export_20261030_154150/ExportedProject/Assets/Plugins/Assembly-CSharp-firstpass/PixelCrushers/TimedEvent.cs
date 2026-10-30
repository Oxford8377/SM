using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class TimedEvent : MonoBehaviour
	{
		public enum TimingMode
		{
			Seconds = 0,
			Frames = 1
		}

		[CompilerGenerated]
		private sealed class _003CCountFrames_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimedEvent _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CCountFrames_003Ed__25(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("Count duration in seconds or number of frames.")]
		private TimingMode m_mode;

		[SerializeField]
		[Tooltip("After starting timer, wait this many seconds before firing event. Mode must be set to Seconds.")]
		private float m_duration;

		[SerializeField]
		[Tooltip("After starting timer, wait this many frames before firing event. Mode must be set to Frames.")]
		private int m_frames;

		[SerializeField]
		[Tooltip("Start timer when this component starts.")]
		private bool m_activateOnStart;

		[SerializeField]
		private UnityEvent m_onTimeReached;

		public TimingMode mode
		{
			get
			{
				return default(TimingMode);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int frames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool activateOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private UnityEvent onTimeReached
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void StartTimer()
		{
		}

		public virtual void StartTimer(float duration)
		{
		}

		[IteratorStateMachine(typeof(_003CCountFrames_003Ed__25))]
		private IEnumerator CountFrames()
		{
			return null;
		}

		protected virtual void CancelTimer()
		{
		}

		protected virtual void TimeReached()
		{
		}

		public void DestroyUnityObject(UnityEngine.Object o)
		{
		}
	}
}

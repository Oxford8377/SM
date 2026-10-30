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
	public class StandardSceneTransitionManager : SceneTransitionManager
	{
		[Serializable]
		public class TransitionInfo
		{
			[Tooltip("Animator for this transition.")]
			public Animator animator;

			[Tooltip("Trigger parameter to set.")]
			public string trigger;

			[Tooltip("Duration to wait for the animation.")]
			public float animationDuration;

			[Tooltip("Total duration to wait for the transition.")]
			public float minTransitionDuration;

			public UnityEvent onTransitionStart;

			public UnityEvent onTransitionEnd;

			public void TriggerAnimation()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLeaveScene_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardSceneTransitionManager _003C_003E4__this;

			private float _003CminAnimationTime_003E5__2;

			private float _003CminEndTime_003E5__3;

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
			public _003CLeaveScene_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CEnterScene_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardSceneTransitionManager _003C_003E4__this;

			private float _003CminAnimationTime_003E5__2;

			private float _003CminEndTime_003E5__3;

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
			public _003CEnterScene_003Ed__6(int _003C_003E1__state)
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

		[Tooltip("Pause time during the transition.")]
		public bool pauseDuringTransition;

		[Tooltip("Transition to play before leaving the current scene.")]
		public TransitionInfo leaveSceneTransition;

		[Tooltip("If set, show this loading scene while loading the real destination scene asynchronously.")]
		public string loadingSceneName;

		[Tooltip("Transition to play after entering the new scene.")]
		public TransitionInfo enterSceneTransition;

		[IteratorStateMachine(typeof(_003CLeaveScene_003Ed__5))]
		public override IEnumerator LeaveScene()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEnterScene_003Ed__6))]
		public override IEnumerator EnterScene()
		{
			return null;
		}
	}
}

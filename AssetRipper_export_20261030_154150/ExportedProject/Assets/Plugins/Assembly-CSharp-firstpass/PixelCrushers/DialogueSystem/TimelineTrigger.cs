using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class TimelineTrigger : DialogueEventStarter
	{
		[CompilerGenerated]
		private sealed class _003CStartAfterOneFrame_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimelineTrigger _003C_003E4__this;

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
			public _003CStartAfterOneFrame_003Ed__24(int _003C_003E1__state)
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

		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

		[Tooltip("Playable Director through which to play the timeline. If a Timeline is assigned, play it when the trigger fires.")]
		public PlayableDirector playableDirector;

		[Tooltip("If Playable Director above is unassigned, or if no asset is assigned to the Playable Director, play this Timeline asset when the trigger fires.")]
		public TimelineAsset timelineAsset;

		public Condition condition;

		[Tooltip("(Optional) Bind these GameObjects to the Timeline's tracks.")]
		public List<GameObject> bindings;

		private bool tryingToStart;

		private bool listenForOnDestroy;

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnUse(Transform actor)
		{
		}

		public void OnUse(string message)
		{
		}

		public void OnUse()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionExit(Collision collision)
		{
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStartAfterOneFrame_003Ed__24))]
		private IEnumerator StartAfterOneFrame()
		{
			return null;
		}

		public void TryStart(Transform actor)
		{
		}

		private void SetBindings()
		{
		}
	}
}

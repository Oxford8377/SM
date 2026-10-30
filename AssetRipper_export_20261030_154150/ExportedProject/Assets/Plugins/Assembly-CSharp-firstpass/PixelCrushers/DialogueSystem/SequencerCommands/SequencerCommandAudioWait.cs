using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandAudioWait : SequencerCommand
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SequencerCommandAudioWait _003C_003E4__this;

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
			public _003CStart_003Ed__9(int _003C_003E1__state)
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

		protected float stopTime;

		protected AudioSource audioSource;

		protected int nextClipIndex;

		protected string audioClipName;

		protected AudioClip currentClip;

		protected AudioClip originalClip;

		protected bool restoreOriginalClip;

		protected bool playedAudio;

		protected bool isLoadingAudio;

		[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
		public virtual IEnumerator Start()
		{
			return null;
		}

		protected virtual AudioSource GetAudioSource(Transform subject)
		{
			return null;
		}

		protected virtual void TryAudioClip(string audioClipName)
		{
		}

		public virtual void Update()
		{
		}

		public virtual void OnDialogueSystemPause()
		{
		}

		public virtual void OnDialogueSystemUnpause()
		{
		}

		public virtual void OnDestroy()
		{
		}
	}
}

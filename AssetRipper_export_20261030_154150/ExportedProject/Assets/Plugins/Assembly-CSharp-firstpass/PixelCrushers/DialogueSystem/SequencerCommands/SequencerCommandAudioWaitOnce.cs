using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandAudioWaitOnce : SequencerCommand
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SequencerCommandAudioWaitOnce _003C_003E4__this;

			private string _003CaudioClipName_003E5__2;

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
			public _003CStart_003Ed__8(int _003C_003E1__state)
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

		private static string _VarPrefix;

		private float _stopTime;

		private AudioSource _audioSource;

		private int _nextClipIndex;

		private AudioClip _currentClip;

		private AudioClip _originalClip;

		private bool _restoreOriginalClip;

		protected bool isLoadingAudio;

		[IteratorStateMachine(typeof(_003CStart_003Ed__8))]
		public IEnumerator Start()
		{
			return null;
		}

		private void TryAudioClip(string audioClipName)
		{
		}

		private string buildOnceVarName(string audioClipName)
		{
			return null;
		}

		private bool hasPlayedAlready(string audioClipName)
		{
			return false;
		}

		private void markAsPlayedAlready(string audioClipName)
		{
		}

		private bool hasNextClip()
		{
			return false;
		}

		public void Update()
		{
		}

		public void OnDialogueSystemPause()
		{
		}

		public void OnDialogueSystemUnpause()
		{
		}

		public void OnDestroy()
		{
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class AbstractTypewriterEffect : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPauseForDuration_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AbstractTypewriterEffect _003C_003E4__this;

			public float duration;

			private float _003CcontinueTime_003E5__2;

			private int _003CpauseSafeguard_003E5__3;

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
			public _003CPauseForDuration_003Ed__40(int _003C_003E1__state)
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

		[Tooltip("Tick for right-to-left text such as Arabic.")]
		public bool rightToLeft;

		[Tooltip("How fast to type. This is separate from Dialogue Manager > Subtitle Settings > Chars Per Second.")]
		public float charactersPerSecond;

		[Tooltip("Optional audio clip to play with each character.")]
		public AudioClip audioClip;

		[Tooltip("If specified, randomly use these clips or the main Audio Clip.")]
		public AudioClip[] alternateAudioClips;

		[Tooltip("Optional audio source through which to play the clip.")]
		public AudioSource audioSource;

		[Tooltip("Use AudioSource.PlayOneShot instead of Play. Slightly heavier performance but produces different effect.")]
		public bool usePlayOneShot;

		[Tooltip("If audio clip is still playing from previous character, stop and restart it when typing next character.")]
		public bool interruptAudioClip;

		[Tooltip("Stop audio when typing any of the Silent Characters specified below.")]
		public bool stopAudioOnSilentCharacters;

		[Tooltip("Stop audio when upon reaching a pause code.")]
		public bool stopAudioOnPauseCodes;

		[Tooltip("Don't play audio on these characters.")]
		public string silentCharacters;

		[Tooltip("Play a full pause on these characters.")]
		public string fullPauseCharacters;

		[Tooltip("Play a quarter pause on these characters.")]
		public string quarterPauseCharacters;

		[Tooltip("Duration to pause on when text contains '\\.'")]
		public float fullPauseDuration;

		[Tooltip("Duration to pause when text contains '\\,'")]
		public float quarterPauseDuration;

		[Tooltip("Ensure this GameObject has only one typewriter effect.")]
		public bool removeDuplicateTypewriterEffects;

		[Tooltip("Play using the current text content whenever component is enabled.")]
		public bool playOnEnable;

		[Tooltip("Wait one frame to allow layout elements to setup first.")]
		public bool waitOneFrameBeforeStarting;

		[Tooltip("Stop typing when the conversation ends.")]
		public bool stopOnConversationEnd;

		protected bool paused;

		public abstract bool isPlaying { get; }

		public virtual float GetSpeed()
		{
			return 0f;
		}

		public virtual void SetSpeed(float charactersPerSecond)
		{
		}

		public virtual void Awake()
		{
		}

		public abstract void Start();

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void StopOnConversationEnd(Transform actor)
		{
		}

		public abstract void Stop();

		public abstract void StartTyping(string text, int fromIndex = 0);

		public abstract void StopTyping();

		public static string StripRPGMakerCodes(string s)
		{
			return null;
		}

		protected virtual void PreprocessPauseCharacters()
		{
		}

		protected virtual bool IsFullPauseCharacter(char c)
		{
			return false;
		}

		protected virtual bool IsQuarterPauseCharacter(char c)
		{
			return false;
		}

		protected virtual bool IsSilentCharacter(char c)
		{
			return false;
		}

		protected bool IsCharacterInString(char c, string s)
		{
			return false;
		}

		public virtual void StopCharacterAudio()
		{
		}

		protected virtual void PlayCharacterAudio(char c)
		{
		}

		protected virtual void PlayCharacterAudio()
		{
		}

		[IteratorStateMachine(typeof(_003CPauseForDuration_003Ed__40))]
		protected virtual IEnumerator PauseForDuration(float duration)
		{
			return null;
		}
	}
}

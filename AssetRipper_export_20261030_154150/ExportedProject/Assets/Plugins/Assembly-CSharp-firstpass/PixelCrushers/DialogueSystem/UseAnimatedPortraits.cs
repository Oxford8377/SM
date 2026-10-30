using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UseAnimatedPortraits : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSetAnimatorAtEndOfFrame_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UseAnimatedPortraits _003C_003E4__this;

			public Subtitle subtitle;

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
			public _003CSetAnimatorAtEndOfFrame_003Ed__8(int _003C_003E1__state)
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

		private UnityUIDialogueUI dialogueUI;

		private Animator npcPortraitAnimator;

		private Animator npcReminderPortraitAnimator;

		private Animator pcPortraitAnimator;

		private Animator otherAnimator;

		private Dictionary<Transform, AnimatedPortrait> animatedPortraits;

		private Transform lastSpeaker;

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		[IteratorStateMachine(typeof(_003CSetAnimatorAtEndOfFrame_003Ed__8))]
		private IEnumerator SetAnimatorAtEndOfFrame(Subtitle subtitle)
		{
			return null;
		}

		public void OnConversationResponseMenu(Response[] responses)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		private bool FindDialogueUI()
		{
			return false;
		}

		private void SetAnimatorController(Image image, Transform speaker, ref Animator animator)
		{
		}
	}
}

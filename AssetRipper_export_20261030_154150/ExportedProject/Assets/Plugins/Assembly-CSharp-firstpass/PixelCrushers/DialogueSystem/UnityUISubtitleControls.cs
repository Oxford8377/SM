using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUISubtitleControls : AbstractUISubtitleControls
	{
		[CompilerGenerated]
		private sealed class _003CSetSubtitlePortrait_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityUISubtitleControls _003C_003E4__this;

			public CharacterType characterType;

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
			public _003CSetSubtitlePortrait_003Ed__18(int _003C_003E1__state)
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

		[Tooltip("Optional panel for the subtitle elements")]
		public Graphic panel;

		[Tooltip("Subtitle text")]
		public Text line;

		[Tooltip("Optional image for speaker's portrait")]
		public Image portraitImage;

		[Tooltip("Optional label for speaker's name")]
		public Text portraitName;

		[Tooltip("Optional continue button; configure OnClick to invoke dialogue UI's OnContinue method")]
		public Button continueButton;

		[Tooltip("Ignore RPGMaker-style pause codes")]
		public bool ignorePauseCodes;

		[Tooltip("Optional animation transitions; panel should have an Animator")]
		public UIAnimationTransitions animationTransitions;

		[Tooltip("When the subtitle UI elements should be visible.")]
		public UIVisibility uiVisibility;

		private UIShowHideController m_showHideController;

		private bool m_haveSavedOriginalColor;

		private Color m_originalColor;

		public bool isVisible => false;

		public override bool hasText => false;

		private UIShowHideController showHideController => null;

		public void CheckSubtitlePortrait(CharacterType characterType)
		{
		}

		[IteratorStateMachine(typeof(_003CSetSubtitlePortrait_003Ed__18))]
		private IEnumerator SetSubtitlePortrait(CharacterType characterType)
		{
			return null;
		}

		public override void SetActive(bool value)
		{
		}

		public void ForceHide()
		{
		}

		public void ForceShow()
		{
		}

		private void ShowPanel()
		{
		}

		private void HidePanel()
		{
		}

		public void ActivateUIElements()
		{
		}

		public void DeactivateUIElements()
		{
		}

		private void SetUIElementsActive(bool value)
		{
		}

		public override void ShowContinueButton()
		{
		}

		public override void HideContinueButton()
		{
		}

		public override void SetSubtitle(Subtitle subtitle)
		{
		}

		public override void ClearSubtitle()
		{
		}

		private void SetFormattedText(Text label, FormattedText formattedText)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public void AutoFocus(bool allowStealFocus = true)
		{
		}
	}
}

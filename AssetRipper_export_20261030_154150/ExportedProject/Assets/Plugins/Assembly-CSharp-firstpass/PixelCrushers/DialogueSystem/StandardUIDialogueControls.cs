using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIDialogueControls : AbstractDialogueUIControls
	{
		[CompilerGenerated]
		private sealed class _003CCloseAfterPanelsAreClosed_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIDialogueControls _003C_003E4__this;

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
			public _003CCloseAfterPanelsAreClosed_003Ed__30(int _003C_003E1__state)
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

		[Tooltip("Main panel for conversation UI (optional).")]
		public UIPanel mainPanel;

		[Tooltip("Never deactivate Main Panel. Will still play show & hide animations if specified.")]
		public bool dontDeactivateMainPanel;

		[Tooltip("When starting conversation, wait until main panel is open before showing subtitle or menu.")]
		public bool waitForMainPanelOpen;

		public StandardUISubtitlePanel[] subtitlePanels;

		[Tooltip("Default panel for NPC subtitles.")]
		public StandardUISubtitlePanel defaultNPCSubtitlePanel;

		[Tooltip("Default panel for PC subtitles.")]
		public StandardUISubtitlePanel defaultPCSubtitlePanel;

		[Tooltip("Check for subtitle panels that are configured to immediately open when conversation starts. Untick to bypass check.")]
		public bool allowOpenSubtitlePanelsOnStartConversation;

		public StandardUIMenuPanel[] menuPanels;

		[Tooltip("Default panel for response menus.")]
		public StandardUIMenuPanel defaultMenuPanel;

		[Tooltip("When showing response menu, use portrait info of player actor assigned to first response. Also use that actor's menu panel if using multiple menu panels.")]
		public bool useFirstResponseForMenuPortrait;

		[Tooltip("When closing, wait for all subtitle panels and menu panels to close.")]
		public bool waitForClose;

		private StandardUISubtitleControls m_standardSubtitleControls;

		private StandardUIResponseMenuControls m_standardMenuControls;

		private bool m_initializedAnimator;

		private Coroutine closeCoroutine;

		public StandardUISubtitleControls standardSubtitleControls => null;

		public override AbstractUISubtitleControls npcSubtitleControls => null;

		public override AbstractUISubtitleControls pcSubtitleControls => null;

		public StandardUIResponseMenuControls standardMenuControls => null;

		public override AbstractUIResponseMenuControls responseMenuControls => null;

		public void Initialize()
		{
		}

		public override void SetActive(bool value)
		{
		}

		public override void ShowPanel()
		{
		}

		private void HidePanel()
		{
		}

		public void ClosePanels()
		{
		}

		[IteratorStateMachine(typeof(_003CCloseAfterPanelsAreClosed_003Ed__30))]
		private IEnumerator CloseAfterPanelsAreClosed()
		{
			return null;
		}

		public bool AreAnyPanelsClosing(StandardUISubtitlePanel extraSubtitlePanel = null)
		{
			return false;
		}

		public void HideImmediate()
		{
		}

		private void HideSubtitlePanelsImmediate()
		{
		}

		private void HideMenuPanelsImmediate()
		{
		}

		public void OpenSubtitlePanelsOnStart(StandardDialogueUI ui)
		{
		}

		public void ClearCaches()
		{
		}

		public virtual void ClearAllSubtitleText()
		{
		}

		public virtual void ClearSubtitleTextOnConversationStart()
		{
		}
	}
}

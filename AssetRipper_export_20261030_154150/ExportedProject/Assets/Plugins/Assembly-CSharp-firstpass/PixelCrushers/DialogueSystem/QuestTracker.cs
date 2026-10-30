using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class QuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1
		}

		private class QuestTrackerLine
		{
			public string guiStyleName;

			public GUIStyle guiStyle;

			public string text;
		}

		[CompilerGenerated]
		private sealed class _003CUpdateTrackerAfterOneFrame_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuestTracker _003C_003E4__this;

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
			public _003CUpdateTrackerAfterOneFrame_003Ed__19(int _003C_003E1__state)
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

		[Tooltip("Record the quest tracker display toggle in this PlayerPrefs key.")]
		public string playerPrefsToggleKey;

		public ScaledRect rect;

		public GUISkin guiSkin;

		public string TitleStyle;

		public string SuccessTitleStyle;

		public string FailureTitleStyle;

		public string ActiveEntryStyle;

		public string SuccessEntryStyle;

		public string FailureEntryStyle;

		public bool showActiveQuests;

		public bool showCompletedQuests;

		public bool showCompletedEntryText;

		public QuestDescriptionSource questDescriptionSource;

		private Rect screenRect;

		private List<QuestTrackerLine> lines;

		private bool isVisible;

		public void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateTrackerAfterOneFrame_003Ed__19))]
		private IEnumerator UpdateTrackerAfterOneFrame()
		{
			return null;
		}

		public void ShowTracker()
		{
		}

		public void HideTracker()
		{
		}

		public void ToggleTracker()
		{
		}

		public void OnQuestTrackingEnabled(string quest)
		{
		}

		public void OnQuestTrackingDisabled(string quest)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void UpdateTracker()
		{
		}

		private void AddQuestTitle(string quest)
		{
		}

		private void AddQuestEntries(string quest)
		{
		}

		private string GetQuestEntryText(string quest, int entryNum, QuestState entryState)
		{
			return null;
		}

		private string GetTitleStyleName(QuestState state)
		{
			return null;
		}

		private string GetEntryStyleName(QuestState entryState)
		{
			return null;
		}

		private void OnGUI()
		{
		}
	}
}

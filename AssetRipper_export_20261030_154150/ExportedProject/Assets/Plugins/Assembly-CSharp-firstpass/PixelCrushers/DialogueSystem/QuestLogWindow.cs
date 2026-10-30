using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class QuestLogWindow : MonoBehaviour
	{
		public enum QuestHeadingSource
		{
			Name = 0,
			Description = 1
		}

		[Serializable]
		public class QuestInfo
		{
			public string Group { get; set; }

			public string GroupDisplayName { get; set; }

			public string Title { get; set; }

			public FormattedText Heading { get; set; }

			public FormattedText Description { get; set; }

			public FormattedText[] Entries { get; set; }

			public QuestState[] EntryStates { get; set; }

			public bool Trackable { get; set; }

			public bool Track { get; set; }

			public bool Abandonable { get; set; }

			public QuestInfo(string group, string groupDisplayName, string title, FormattedText heading, FormattedText description, FormattedText[] entries, QuestState[] entryStates, bool trackable, bool track, bool abandonable)
			{
			}

			public QuestInfo(string group, string title, FormattedText heading, FormattedText description, FormattedText[] entries, QuestState[] entryStates, bool trackable, bool track, bool abandonable)
			{
			}

			public QuestInfo(string title, FormattedText heading, FormattedText description, FormattedText[] entries, QuestState[] entryStates, bool trackable, bool track, bool abandonable)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CUpdateQuestDisplayAtEndOfFrame_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuestLogWindow _003C_003E4__this;

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
			public _003CUpdateQuestDisplayAtEndOfFrame_003Ed__95(int _003C_003E1__state)
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

		[Tooltip("Optional localized text table to use to localize no active/completed quests.")]
		public TextTable textTable;

		[Tooltip("Text to show (or localize) when there are no active quests.")]
		public string noActiveQuestsText;

		[Tooltip("Text to show (or localize) when there are no completed quests.")]
		public string noCompletedQuestsText;

		[Tooltip("Check if quest has a field named 'Visible'. If field is false, don't show quest.")]
		public bool checkVisibleField;

		public QuestHeadingSource questHeadingSource;

		[Tooltip("State to assign to quests when player abandons then.")]
		[QuestState]
		public QuestState abandonQuestState;

		public bool pauseWhileOpen;

		public bool unlockCursorWhileOpen;

		[Tooltip("Organize quests by the values of their Group fields.")]
		public bool useGroups;

		[Tooltip("If not blank, show this text next to quest titles that haven't been viewed yet. Will be localized if text has entry in Dialogue Manager's Text Table.")]
		public string newQuestText;

		[Tooltip("Allow only one quest to be tracked at a time.")]
		public bool trackOneQuestAtATime;

		[Tooltip("Clicking again on selected quest title deselects quest.")]
		public bool deselectQuestOnSecondClick;

		protected const QuestState ActiveQuestStateMask = QuestState.Active | QuestState.ReturnToNPC;

		protected QuestState currentQuestStateMask;

		protected float previousTimeScale;

		protected Coroutine refreshCoroutine;

		protected bool started;

		private bool wasCursorActive;

		public bool isOpen { get; protected set; }

		public QuestInfo[] quests { get; protected set; }

		public string[] groups { get; protected set; }

		public string selectedQuest { get; protected set; }

		public string noQuestsMessage { get; protected set; }

		public virtual bool isShowingActiveQuests => false;

		public bool IsOpen
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public QuestInfo[] Quests
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string[] Groups
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string SelectedQuest
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string NoQuestsMessage
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool IsShowingActiveQuests => false;

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void RegisterForUpdateTrackerEvents()
		{
		}

		protected void UnregisterFromUpdateTrackerEvents()
		{
		}

		public virtual void OpenWindow(Action openedWindowHandler)
		{
		}

		public virtual void CloseWindow(Action closedWindowHandler)
		{
		}

		public virtual void OnQuestListUpdated()
		{
		}

		public virtual void ConfirmAbandonQuest(string title, Action confirmedAbandonQuestHandler)
		{
		}

		public virtual void Open()
		{
		}

		protected virtual void OnOpenedWindow()
		{
		}

		public virtual void Close()
		{
		}

		protected virtual void OnClosedWindow()
		{
		}

		protected virtual void PauseGameplay()
		{
		}

		protected virtual void ResumeGameplay()
		{
		}

		public virtual bool IsQuestVisible(string questTitle)
		{
			return false;
		}

		protected virtual void ShowQuests(QuestState questStateMask)
		{
		}

		protected virtual QuestInfo GetQuestInfo(string group, string title)
		{
			return null;
		}

		protected virtual string GetNoQuestsMessage(QuestState questStateMask)
		{
			return null;
		}

		public virtual string GetLocalizedText(string fieldName)
		{
			return null;
		}

		public virtual bool IsSelectedQuest(QuestInfo questInfo)
		{
			return false;
		}

		public void ClickClose(object data)
		{
		}

		public virtual void ClickShowActiveQuests(object data)
		{
		}

		public virtual void ClickShowCompletedQuests(object data)
		{
		}

		public virtual void ClickQuest(object data)
		{
		}

		public virtual void ClickAbandonQuest(object data)
		{
		}

		protected virtual void OnConfirmAbandonQuest()
		{
		}

		public virtual void ClickTrackQuest(object data)
		{
		}

		private bool IsString(object data)
		{
			return false;
		}

		public virtual void ClickShowActiveQuestsButton()
		{
		}

		public void ClickShowCompletedQuestsButton()
		{
		}

		public void ClickCloseButton()
		{
		}

		public void ClickAbandonQuestButton()
		{
		}

		public void ClickTrackQuestButton()
		{
		}

		public void UpdateTracker()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateQuestDisplayAtEndOfFrame_003Ed__95))]
		protected IEnumerator UpdateQuestDisplayAtEndOfFrame()
		{
			return null;
		}
	}
}

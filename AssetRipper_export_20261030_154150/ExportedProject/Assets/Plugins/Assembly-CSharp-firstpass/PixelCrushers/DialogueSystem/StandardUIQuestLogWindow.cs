using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIQuestLogWindow : QuestLogWindow
	{
		[CompilerGenerated]
		private sealed class _003CRefreshAtEndOfFrame_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIQuestLogWindow _003C_003E4__this;

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
			public _003CRefreshAtEndOfFrame_003Ed__48(int _003C_003E1__state)
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
		private sealed class _003CSelectElement_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Selectable elementToSelect;

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
			public _003CSelectElement_003Ed__54(int _003C_003E1__state)
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

		[Header("Main Panel")]
		public UIPanel mainPanel;

		public UITextField showingActiveQuestsHeading;

		public UITextField showingCompletedQuestHeading;

		[Tooltip("Button to switch display to active quests.")]
		public Button activeQuestsButton;

		[Tooltip("Button to switch display to completed quests.")]
		public Button completedQuestsButton;

		[Header("Selection Panel")]
		public RectTransform questSelectionContentContainer;

		public StandardUIFoldoutTemplate questGroupTemplate;

		[Tooltip("Use this template for active quests.")]
		public StandardUIQuestTitleButtonTemplate activeQuestHeadingTemplate;

		[Tooltip("Use this template for the currently-selected active quest.")]
		public StandardUIQuestTitleButtonTemplate selectedActiveQuestHeadingTemplate;

		[Tooltip("Use this template for completed quests.")]
		public StandardUIQuestTitleButtonTemplate completedQuestHeadingTemplate;

		[Tooltip("Use this template for the currently-selected completed quest.")]
		public StandardUIQuestTitleButtonTemplate selectedCompletedQuestHeadingTemplate;

		[Tooltip("If there are no quests to show, show the No Active/Completed Quests Text above.")]
		public bool showNoQuestsText;

		[Tooltip("Select first quest in list when open. If unticked and Always Auto Focus is ticked, selects button assigned to main panel's First Selected field (Close button).")]
		public bool selectFirstQuestOnOpen;

		[Tooltip("Show details when quest button is selected (highlighted/hovered), not when clicked.")]
		public bool showDetailsOnSelect;

		[Tooltip("Keep all groups expanded.")]
		public bool keepGroupsExpanded;

		[Header("Details Panel")]
		public RectTransform questDetailsContentContainer;

		public StandardUITextTemplate questHeadingTextTemplate;

		public StandardUITextTemplate questDescriptionTextTemplate;

		public StandardUITextTemplate questEntryActiveTextTemplate;

		public StandardUITextTemplate questEntrySuccessTextTemplate;

		public StandardUITextTemplate questEntryFailureTextTemplate;

		public StandardUIButtonTemplate abandonButtonTemplate;

		[Header("Abandon Quest Panel")]
		public UIPanel abandonQuestPanel;

		public UITextField abandonQuestTitleText;

		[Header("Events")]
		public UnityEvent onOpen;

		public UnityEvent onClose;

		[Tooltip("Add an EventSystem if one isn't in the scene.")]
		public bool addEventSystemIfNeeded;

		private StandardUIInstancedContentManager m_selectionPanelContentManager;

		private StandardUIInstancedContentManager m_detailsPanelContentManager;

		protected List<string> expandedGroupNames;

		protected Action confirmAbandonQuestHandler;

		private Coroutine m_refreshCoroutine;

		private bool m_isAwake;

		public string foldoutToSelect;

		public string questTitleToSelect;

		protected StandardUIInstancedContentManager selectionPanelContentManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected StandardUIInstancedContentManager detailsPanelContentManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		protected virtual void InitializeTemplates()
		{
		}

		public override void OpenWindow(Action openedWindowHandler)
		{
		}

		public override void CloseWindow(Action closedWindowHandler)
		{
		}

		public virtual void Toggle()
		{
		}

		public virtual bool IsGroupExpanded(string groupName)
		{
			return false;
		}

		public virtual void ToggleGroup(string groupName)
		{
		}

		protected void SetStateToggleButtons()
		{
		}

		public virtual void Repaint()
		{
		}

		[IteratorStateMachine(typeof(_003CRefreshAtEndOfFrame_003Ed__48))]
		private IEnumerator RefreshAtEndOfFrame()
		{
			return null;
		}

		public override void OnQuestListUpdated()
		{
		}

		protected virtual StandardUIQuestTitleButtonTemplate GetQuestTitleTemplate(QuestInfo quest)
		{
			return null;
		}

		protected virtual StandardUIQuestTitleButtonTemplate GetSelectedQuestTitleTemplate(QuestInfo quest)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectElement_003Ed__54))]
		protected IEnumerator SelectElement(Selectable elementToSelect)
		{
			return null;
		}

		protected virtual void AddShowDetailsOnSelect(Button button, string target)
		{
		}

		protected virtual void OnClickGroup(string groupName, StandardUIFoldoutTemplate groupFoldout)
		{
		}

		protected virtual void ShowDetailsOnSelect(string questTitle)
		{
		}

		protected virtual void OnClickQuest(string questTitle)
		{
		}

		public virtual void SelectQuest(string questTitle)
		{
		}

		protected virtual void RepaintSelectedQuest(QuestInfo quest)
		{
		}

		protected virtual StandardUITextTemplate GetEntryTemplate(QuestState state)
		{
			return null;
		}

		public virtual void OnToggleTracking(bool value, object data)
		{
		}

		public override void ConfirmAbandonQuest(string title, Action confirmAbandonQuestHandler)
		{
		}

		public virtual void AbandonQuestConfirmed()
		{
		}

		protected override void ShowQuests(QuestState questStateMask)
		{
		}
	}
}

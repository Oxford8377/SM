using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIQuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1
		}

		[CompilerGenerated]
		private sealed class _003CRefreshAtEndOfFrame_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIQuestTracker _003C_003E4__this;

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
			public _003CRefreshAtEndOfFrame_003Ed__28(int _003C_003E1__state)
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

		[Tooltip("Record the quest tracker display toggle in this PlayerPrefs key. Leave blank to not record tracker visible/invisible state.")]
		public string playerPrefsToggleKey;

		[Tooltip("UI container that will hold instances of quest track template.")]
		public Transform container;

		[Tooltip("Show Container even if there's nothing to track.")]
		public bool showContainerIfEmpty;

		[Tooltip("Template to instantiate for each tracked quest.")]
		public StandardUIQuestTrackTemplate questTrackTemplate;

		[Tooltip("Show active quests.")]
		public bool showActiveQuests;

		[Tooltip("Show successful and failed quests.")]
		public bool showCompletedQuests;

		[Tooltip("Show Entry n Success or Entry n Failure text if quest entry is in success/failure state.")]
		public bool showCompletedEntryText;

		[Tooltip("Source for the quest tracker text.")]
		public QuestDescriptionSource questDescriptionSource;

		public bool visibleOnStart;

		protected List<StandardUIQuestTrackTemplate> instantiatedItems;

		protected List<StandardUIQuestTrackTemplate> unusedInstances;

		protected int siblingIndexCounter;

		protected bool m_started;

		protected bool isVisible;

		protected Coroutine refreshCoroutine;

		public virtual void Start()
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

		public virtual void ShowTracker()
		{
		}

		public virtual void HideTracker()
		{
		}

		public virtual void ToggleTracker()
		{
		}

		public virtual void OnQuestTrackingEnabled(string quest)
		{
		}

		public virtual void OnQuestTrackingDisabled(string quest)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public virtual void UpdateTracker()
		{
		}

		[IteratorStateMachine(typeof(_003CRefreshAtEndOfFrame_003Ed__28))]
		protected virtual IEnumerator RefreshAtEndOfFrame()
		{
			return null;
		}

		protected virtual void AddQuestTrack(string quest)
		{
		}

		protected virtual string GetQuestHeading(string quest)
		{
			return null;
		}

		protected virtual void SetupQuestTrackInstance(StandardUIQuestTrackTemplate questTrack, string quest, string heading)
		{
		}

		protected virtual string GetQuestEntryText(string quest, int entryNum, QuestState entryState)
		{
			return null;
		}
	}
}

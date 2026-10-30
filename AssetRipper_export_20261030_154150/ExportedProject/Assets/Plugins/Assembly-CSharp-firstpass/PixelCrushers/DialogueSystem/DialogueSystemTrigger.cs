using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class DialogueSystemTrigger : MonoBehaviour
	{
		[Serializable]
		public class SendMessageAction
		{
			[Tooltip("Target GameObject.")]
			public GameObject gameObject;

			[Tooltip("Name of method to call on target. One or more scripts on target should have a method with this name.")]
			public string message;

			[Tooltip("Optional method parameter. Specify if method accepts a string parameter.")]
			public string parameter;
		}

		public enum BarkSource
		{
			None = 0,
			Conversation = 1,
			Text = 2
		}

		[Serializable]
		public class SetGameObjectActiveAction
		{
			public Condition condition;

			public Transform target;

			public Toggle state;
		}

		[Serializable]
		public class SetComponentEnabledAction
		{
			public Condition condition;

			public Component target;

			public Toggle state;
		}

		[Serializable]
		public class SetAnimatorStateAction
		{
			public Condition condition;

			[Tooltip("Set the state of the animator on this GameObject. Animator can be on a child GameObject.")]
			public Transform target;

			[Tooltip("State to crossfade to.")]
			public string stateName;

			public float crossFadeDuration;
		}

		[CompilerGenerated]
		private sealed class _003CShowCursorAfterOneFrame_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CShowCursorAfterOneFrame_003Ed__85(int _003C_003E1__state)
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
		private sealed class _003CStartAtEndOfFrame_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemTrigger _003C_003E4__this;

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
			public _003CStartAtEndOfFrame_003Ed__104(int _003C_003E1__state)
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
		private sealed class _003CFireIfNoSaveDataApplied_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemTrigger _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CFireIfNoSaveDataApplied_003Ed__106(int _003C_003E1__state)
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
		private sealed class _003CMonitorDistance_003Ed__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform actor;

			public DialogueSystemTrigger _003C_003E4__this;

			private Transform _003CmyTransform_003E5__2;

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
			public _003CMonitorDistance_003Ed__128(int _003C_003E1__state)
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

		[Tooltip("The trigger that this component listens for.")]
		[DialogueSystemTriggerEvent]
		public DialogueSystemTriggerEvent trigger;

		public Condition condition;

		[Tooltip("Set a quest state when triggered.")]
		public bool setQuestState;

		[QuestPopup(false)]
		public string questName;

		[Tooltip("Set quest's main state.")]
		[QuestState]
		public QuestState questState;

		[Tooltip("Set state of a quest entry.")]
		public bool setQuestEntryState;

		[QuestEntryPopup]
		public int questEntryNumber;

		[QuestState]
		public QuestState questEntryState;

		public bool setAnotherQuestEntryState;

		[QuestEntryPopup]
		public int anotherQuestEntryNumber;

		[QuestState]
		public QuestState anotherQuestEntryState;

		[Tooltip("Lua code to run. Leave blank for no message.")]
		public string luaCode;

		[TextArea(1, 10)]
		public string sequence;

		[Tooltip("Optional GameObject to use if sequence uses 'speaker' keyword.")]
		public Transform sequenceSpeaker;

		[Tooltip("Optional GameObject to use if sequence uses 'listener' keyword.")]
		public Transform sequenceListener;

		public bool waitOneFrameOnStartOrEnable;

		[Tooltip("Alert message. Leave blank for no message.")]
		public string alertMessage;

		[Tooltip("Optional text table to use to localize messages.")]
		public TextTable textTable;

		public float alertDuration;

		public SendMessageAction[] sendMessages;

		[Tooltip("Where to get content to bark.")]
		public BarkSource barkSource;

		[ConversationPopup(false, true)]
		[Tooltip("Conversation to get bark content from.")]
		public string barkConversation;

		[Tooltip("Bark this text. Will be localized through Dialogue Manager's Text Table if assigned.")]
		public string barkText;

		[Tooltip("Optional sequence to play when barking text.")]
		public string barkTextSequence;

		[Tooltip("Character that bark comes from. Should have a bark UI or a Dialogue Actor component with a bark UI prefab assigned.")]
		public Transform barker;

		[Tooltip("Optional target of the bark. Receives OnBark events.")]
		public Transform barkTarget;

		public BarkOrder barkOrder;

		public bool allowBarksDuringConversations;

		[Tooltip("Only trigger if at least one entry's Conditions are currently true.")]
		public bool skipBarkIfNoValidEntries;

		[Tooltip("Cache all lines during first bark. This can reduce stutter when barking on slower mobile devices, but barks' conditions are not reevaluated each time as the state changes, barks use no em formatting codes, and sequences are not played with barks.")]
		public bool cacheBarkLines;

		[Tooltip("Conversation to start. Leave blank for no conversation.")]
		[ConversationPopup(false, true)]
		public string conversation;

		[Tooltip("Other actor (e.g., NPC). If unassigned, this GameObject.")]
		public Transform conversationConversant;

		[Tooltip("Primary actor (e.g., player). If unassigned, GameObject that triggered conversation.")]
		public Transform conversationActor;

		[Tooltip("Start at this entry ID.")]
		public int startConversationEntryID;

		[Tooltip("Start at entry with this Title.")]
		public string startConversationEntryTitle;

		[Tooltip("Only trigger if no other conversation is already active.")]
		public bool exclusive;

		[Tooltip("Stop other conversation if one is active.")]
		public bool replace;

		[Tooltip("Only trigger if at least one entry's Conditions are currently true.")]
		public bool skipIfNoValidEntries;

		[Tooltip("Disallow conversation if same conversation just ended on this frame.")]
		public bool preventRestartOnSameFrameEnded;

		[Tooltip("Stop conversation if actor leaves trigger area.")]
		public bool stopConversationOnTriggerExit;

		[Tooltip("Stop conversation if Conversation Actor exceeds Max Conversation Distance from this trigger's GameObject.")]
		public bool stopConversationIfTooFar;

		[Tooltip("If Stop Conversation If Too Far is ticked, this is too far.")]
		public float maxConversationDistance;

		[Tooltip("Check distance on this frequency.")]
		public float monitorConversationDistanceFrequency;

		[Tooltip("Make the cursor visible when the conversation starts. Return to previous visibility state when conversation ends.")]
		public bool showCursorDuringConversation;

		[Tooltip("Set Time.timeScale to 0 during conversation, back to previous timeScale when conversation ends.")]
		public bool pauseGameDuringConversation;

		public SetGameObjectActiveAction[] setActiveActions;

		public SetComponentEnabledAction[] setEnabledActions;

		public SetAnimatorStateAction[] setAnimatorStateActions;

		public GameObjectUnityEvent onExecute;

		[HideInInspector]
		public bool useConversationTitlePicker;

		[HideInInspector]
		public bool useBarkTitlePicker;

		[HideInInspector]
		public bool useQuestNamePicker;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		protected BarkHistory barkHistory;

		protected ConversationState cachedState;

		protected BarkGroupMember barkGroupMember;

		protected IBarkUI barkUI;

		protected float earliestTimeToAllowTriggerExit;

		protected const float MarginToAllowTriggerExit = 0.2f;

		protected Coroutine monitorDistanceCoroutine;

		protected bool wasCursorVisible;

		protected CursorLockMode savedLockState;

		protected bool didIPause;

		protected float preConversationTimeScale;

		protected int frameConversationEnded;

		protected bool tryingToStart;

		protected bool hasSaveSystem;

		protected Coroutine fireIfNoSaveDataAppliedCoroutine;

		protected ActiveConversationRecord activeConversation;

		protected bool listenForOnDestroy;

		public Sequencer sequencer { get; protected set; }

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void OnBarkStart(Transform actor)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		private void OnConversationStartAnywhere(Transform actor)
		{
		}

		[IteratorStateMachine(typeof(_003CShowCursorAfterOneFrame_003Ed__85))]
		protected IEnumerator ShowCursorAfterOneFrame()
		{
			return null;
		}

		private void OnConversationEndAnywhere(Transform actor)
		{
		}

		public void OnSequenceStart(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnSequenceEnd()
		{
		}

		public void OnUse(Transform actor)
		{
		}

		public void OnUse(string message)
		{
		}

		public void OnUse()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		protected void CheckOnTriggerExit(Transform otherTransform)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionExit(Collision collision)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStartAtEndOfFrame_003Ed__104))]
		protected IEnumerator StartAtEndOfFrame()
		{
			return null;
		}

		protected virtual void OnSaveDataApplied()
		{
		}

		[IteratorStateMachine(typeof(_003CFireIfNoSaveDataApplied_003Ed__106))]
		protected virtual IEnumerator FireIfNoSaveDataApplied()
		{
			return null;
		}

		public void TryStart(Transform actor)
		{
		}

		public virtual void TryStart(Transform actor, Transform interactor)
		{
		}

		public virtual void Fire(Transform actor)
		{
		}

		protected virtual void DoQuestAction()
		{
		}

		protected virtual void DoLuaAction(Transform actor)
		{
		}

		protected virtual void DoLuaAction()
		{
		}

		protected virtual void DoSequenceAction(Transform actor)
		{
		}

		protected virtual void DoAlertAction()
		{
		}

		protected virtual void DoSendMessageActions()
		{
		}

		protected virtual void DoBarkAction(Transform actor)
		{
		}

		protected virtual Transform GetBarker(string conversation)
		{
			return null;
		}

		protected virtual string GetBarkerName()
		{
			return null;
		}

		protected virtual void BarkCachedLine(Transform speaker, Transform listener)
		{
		}

		protected void PopulateCache(Transform speaker, Transform listener)
		{
		}

		protected void BarkNextCachedLine(Transform speaker, Transform listener)
		{
		}

		public void ResetBarkHistory()
		{
		}

		protected virtual void DoConversationAction(Transform actor)
		{
		}

		private float GetCurrentDialogueTime()
		{
			return 0f;
		}

		private int GetEntryIDFromTitle(string conversation, string entryTitle)
		{
			return 0;
		}

		protected virtual void StopActiveConversation()
		{
		}

		protected void StopMonitoringConversationDistance()
		{
		}

		[IteratorStateMachine(typeof(_003CMonitorDistance_003Ed__128))]
		protected IEnumerator MonitorDistance(Transform actor)
		{
			return null;
		}

		protected virtual void DoSetActiveActions(Transform actor)
		{
		}

		protected virtual void DoSetEnabledActions(Transform actor)
		{
		}

		protected virtual void DoSetAnimatorStateActions(Transform actor)
		{
		}

		public void OnRecordPersistentData()
		{
		}

		public void OnApplyPersistentData()
		{
		}
	}
}

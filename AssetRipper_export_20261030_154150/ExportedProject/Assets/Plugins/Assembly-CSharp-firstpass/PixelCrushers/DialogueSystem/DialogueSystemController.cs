using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class DialogueSystemController : MonoBehaviour
	{
		public enum WarmUpMode
		{
			On = 0,
			Extra = 1,
			Off = 2
		}

		[CompilerGenerated]
		private sealed class _003CWarmUpConversationControllerExtra_003Ed__203 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemController _003C_003E4__this;

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
			public _003CWarmUpConversationControllerExtra_003Ed__203(int _003C_003E1__state)
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
		private sealed class _003CHideAndDestroyUICoroutine_003Ed__224 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardDialogueUI standardDialogueUI;

			public DialogueSystemController _003C_003E4__this;

			private float _003Ctimeout_003E5__2;

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
			public _003CHideAndDestroyUICoroutine_003Ed__224(int _003C_003E1__state)
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
		private sealed class _003CChooseResponseAfterOneFrame_003Ed__230 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemController _003C_003E4__this;

			public ResponseTimeoutAction responseTimeoutAction;

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
			public _003CChooseResponseAfterOneFrame_003Ed__230(int _003C_003E1__state)
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
		private sealed class _003CMonitorAlerts_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemController _003C_003E4__this;

			private float _003CcurrentFrequency_003E5__2;

			private WaitForSeconds _003CwaitForSeconds_003E5__3;

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
			public _003CMonitorAlerts_003Ed__241(int _003C_003E1__state)
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
		private sealed class _003CAddLuaObserverAfterStart_003Ed__278 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemController _003C_003E4__this;

			public string luaExpression;

			public LuaWatchFrequency frequency;

			public LuaChangedDelegate luaChangedHandler;

			private int _003CMaxFramesToWait_003E5__2;

			private int _003CframesWaited_003E5__3;

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
			public _003CAddLuaObserverAfterStart_003Ed__278(int _003C_003E1__state)
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

		[Tooltip("This dialogue database is loaded automatically. Use an Extra Databases component to load additional databases.")]
		public DialogueDatabase initialDatabase;

		public DisplaySettings displaySettings;

		public PersistentDataSettings persistentDataSettings;

		[Tooltip("Allow more than one conversation to play simultaneously.")]
		public bool allowSimultaneousConversations;

		[Tooltip("If not allowing simultaneous conversations and a conversation is active, stop it if another conversation wants to start.")]
		public bool interruptActiveConversations;

		[Tooltip("Tick if your conversations reference Dialog[x].SimStatus.")]
		public bool includeSimStatus;

		[Tooltip("Use a copy of the dialogue database at runtime instead of the asset file directly. This allows you to change the database without affecting the asset.")]
		public bool instantiateDatabase;

		[Tooltip("Preload the dialogue database and dialogue UI at Start. Otherwise they're loaded at first use.")]
		public bool preloadResources;

		[Tooltip("Warm up conversation engine and dialogue UI at Start to avoid a small amount of overhead on first use. 'Extra' performs deeper warmup that takes 1.25s at startup.")]
		public WarmUpMode warmUpConversationController;

		[Tooltip("Don't run HideImmediate on dialogue UI when warming it up on start.")]
		public bool dontHideImmediateDuringWarmup;

		[Tooltip("Retain this GameObject when changing levels. Note: If InputDeviceManager's Singleton checkbox is ticked or GameObject has SaveSystem, GameObject will still be marked Don't Destroy On Load.")]
		public bool dontDestroyOnLoad;

		[Tooltip("Ensure only one Dialogue Manager in the scene.")]
		public bool allowOnlyOneInstance;

		[Tooltip("Dialogue System Triggers set to OnStart should wait until save data has been applied or variables initialized.")]
		public bool onStartTriggerWaitForSaveDataApplied;

		[Tooltip("Time mode to use for conversations.\nRealtime: Independent of Time.timeScale.\nGameplay: Observe Time.timeScale.\nCustom: You must manually set DialogueTime.time.")]
		public DialogueTime.TimeMode dialogueTimeMode;

		[Tooltip("Set to higher levels for troubleshooting.")]
		public DialogueDebug.DebugLevel debugLevel;

		public GetLocalizedTextDelegate overrideGetLocalizedText;

		private bool m_isInitialized;

		private const string DefaultDialogueUIResourceName = "Default Dialogue UI";

		private DatabaseManager m_databaseManager;

		private IDialogueUI m_currentDialogueUI;

		[HideInInspector]
		private IDialogueUI m_originalDialogueUI;

		[HideInInspector]
		private DisplaySettings m_originalDisplaySettings;

		private bool m_overrodeDisplaySettings;

		private bool m_isOverrideUIPrefab;

		private bool m_dontDestroyOverrideUI;

		private OverrideDialogueUI m_overrideDialogueUI;

		private ConversationController m_conversationController;

		private IsDialogueEntryValidDelegate m_isDialogueEntryValid;

		private Action m_customResponseTimeoutHandler;

		private GetInputButtonDownDelegate m_savedGetInputButtonDownDelegate;

		private LuaWatchers m_luaWatchers;

		private AssetBundleManager m_assetBundleManager;

		private bool m_started;

		private DialogueDebug.DebugLevel m_lastDebugLevelSet;

		private List<ActiveConversationRecord> m_activeConversations;

		private UILocalizationManager m_uiLocalizationManager;

		private bool m_calledRandomizeNextEntry;

		private bool m_isDuplicateBeingDestroyed;

		private Coroutine warmupCoroutine;

		public static bool isWarmingUp;

		public static bool applicationIsQuitting;

		public static string lastInitialDatabaseName;

		private bool m_unloadAddressablesOnSceneChange;

		private bool m_disableInput;

		private Conversation fakeConversation;

		private StandardDialogueUI warmupStandardDialogueUI;

		private ConversationController warmupController;

		private bool addTempCanvasGroup;

		private CanvasGroup warmupCanvasGroup;

		private DialogueDebug.DebugLevel warmupPreviousLogLevel;

		private float warmupPreviousAlpha;

		private const int FakeConversationID = -1;

		private const string FakeConversationTitle = "__Internal_Warmup__";

		protected Dictionary<string, List<AssetLoadedDelegate>> m_assetsBeingLoaded;

		public bool isInitialized => false;

		public DatabaseManager databaseManager => null;

		public DialogueDatabase masterDatabase => null;

		public IDialogueUI dialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StandardDialogueUI standardDialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IsDialogueEntryValidDelegate isDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action customResponseTimeoutHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GetInputButtonDownDelegate getInputButtonDown { get; set; }

		public bool isConversationActive => false;

		public bool isAlternateConversationActive { get; set; }

		public Transform currentActor { get; private set; }

		public Transform currentConversant { get; private set; }

		public ConversationState currentConversationState { get; set; }

		public string lastConversationStarted { get; private set; }

		public string lastConversationEnded { get; set; }

		public int lastConversationID { get; private set; }

		public ConversationController conversationController => null;

		public ConversationModel conversationModel => null;

		public ConversationView conversationView => null;

		public List<ActiveConversationRecord> activeConversations => null;

		public ActiveConversationRecord activeConversation { get; set; }

		public DatabaseManager DatabaseManager => null;

		public DialogueDatabase MasterDatabase => null;

		public IDialogueUI DialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IsDialogueEntryValidDelegate IsDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GetInputButtonDownDelegate GetInputButtonDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsConversationActive => false;

		public Transform CurrentActor
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Transform CurrentConversant
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConversationState CurrentConversationState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LastConversationStarted
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LastConversationID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ConversationController ConversationController => null;

		public ConversationModel ConversationModel => null;

		public ConversationView ConversationView => null;

		public List<ActiveConversationRecord> ActiveConversations => null;

		public bool allowLuaExceptions { get; set; }

		public bool warnIfActorAndConversantSame { get; set; }

		public bool unloadAddressablesOnSceneChange
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action receivedUpdateTracker
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event TransformDelegate conversationStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event TransformDelegate conversationEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action initializationComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnDestroy()
		{
		}

		public void Awake()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public bool StandardGetInputButtonDown(string buttonName)
		{
			return false;
		}

		private bool DisabledGetInputButtonDown(string buttonName)
		{
			return false;
		}

		public bool IsDialogueSystemInputDisabled()
		{
			return false;
		}

		public void SetDialogueSystemInput(bool value)
		{
		}

		public void Start()
		{
		}

		private void InitializeDisplaySettings()
		{
		}

		private void InitializeLocalization()
		{
		}

		public void SetLanguage(string language)
		{
		}

		private void CheckDebugLevel()
		{
		}

		private void InitializeDatabase()
		{
		}

		public void AddDatabase(DialogueDatabase database)
		{
		}

		public void RemoveDatabase(DialogueDatabase database)
		{
		}

		public void ResetDatabase(DatabaseResetOptions databaseResetOptions)
		{
		}

		public void ResetDatabase()
		{
		}

		public void PreloadMasterDatabase()
		{
		}

		public void PreloadDialogueUI()
		{
		}

		public bool ConversationHasValidEntry(string title, Transform actor, Transform conversant, int initialDialogueEntryID = -1)
		{
			return false;
		}

		public bool ConversationHasValidEntry(string title, Transform actor)
		{
			return false;
		}

		public bool ConversationHasValidEntry(string title)
		{
			return false;
		}

		public void PreloadResources()
		{
		}

		public void WarmUpConversationController()
		{
		}

		[IteratorStateMachine(typeof(_003CWarmUpConversationControllerExtra_003Ed__203))]
		private IEnumerator WarmUpConversationControllerExtra()
		{
			return null;
		}

		private void InterruptExtraWarmup()
		{
		}

		private void FinishExtraWarmup()
		{
		}

		private void ResetWarmupVariables()
		{
		}

		private Conversation CreateFakeConversation()
		{
			return null;
		}

		public void StartConversation(string title, Transform actor, Transform conversant, int initialDialogueEntryID)
		{
		}

		public void StartConversation(string title, Transform actor, Transform conversant)
		{
		}

		public void StartConversation(string title, Transform actor)
		{
		}

		public void StartConversation(string title)
		{
		}

		public void StopConversation()
		{
		}

		public void StopAllConversations()
		{
		}

		public void UpdateResponses()
		{
		}

		public Transform FindActorTransformFromConversation(string conversationTitle, string actorField)
		{
			return null;
		}

		public void SetPortrait(string actorName, string portraitName)
		{
		}

		public void SetActorPortraitSprite(string actorName, Sprite sprite)
		{
		}

		private void SetConversationUI(Transform actor, Transform conversant)
		{
		}

		private OverrideUIBase FindHighestPriorityOverrideUI(Transform actor, Transform conversant)
		{
			return null;
		}

		private OverrideUIBase FindOverrideUI(Transform character)
		{
			return null;
		}

		private void ApplyOverrideUI(OverrideUIBase overrideUI)
		{
		}

		private void RestoreOriginalUI()
		{
		}

		private void HideAndDestroyUI(MonoBehaviour uiBehaviour)
		{
		}

		[IteratorStateMachine(typeof(_003CHideAndDestroyUICoroutine_003Ed__224))]
		private IEnumerator HideAndDestroyUICoroutine(StandardDialogueUI standardDialogueUI)
		{
			return null;
		}

		private void OnDialogueEntrySpoken(Subtitle subtitle)
		{
		}

		public void OnEndConversation(ConversationController endingConversationController)
		{
		}

		public void OnConversationTimeout()
		{
		}

		private void OnConversationStart(Transform actor)
		{
		}

		private void OnConversationEnd(Transform actor)
		{
		}

		[IteratorStateMachine(typeof(_003CChooseResponseAfterOneFrame_003Ed__230))]
		private IEnumerator ChooseResponseAfterOneFrame(ResponseTimeoutAction responseTimeoutAction)
		{
			return null;
		}

		public void Bark(string conversationTitle, Transform speaker, Transform listener, BarkHistory barkHistory)
		{
		}

		public void Bark(string conversationTitle, Transform speaker, Transform listener)
		{
		}

		public void Bark(string conversationTitle, Transform speaker)
		{
		}

		public void Bark(string conversationTitle, Transform speaker, BarkHistory barkHistory)
		{
		}

		public void BarkString(string barkText, Transform speaker, Transform listener = null, string sequence = null)
		{
		}

		public float GetBarkDuration(string barkText)
		{
			return 0f;
		}

		private CharacterInfo GetCharacterInfoFromTransform(Transform actorTransform)
		{
			return null;
		}

		public void ShowAlert(string message, float duration)
		{
		}

		public void ShowAlert(string message)
		{
		}

		public void CheckAlerts()
		{
		}

		[IteratorStateMachine(typeof(_003CMonitorAlerts_003Ed__241))]
		private IEnumerator MonitorAlerts()
		{
			return null;
		}

		public void HideAlert()
		{
		}

		public string GetLocalizedText(string s)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone, string entrytag)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence)
		{
			return null;
		}

		public void StopSequence(Sequencer sequencer)
		{
		}

		public void Pause()
		{
		}

		public void Unpause()
		{
		}

		private void BroadcastDialogueSystemMessage(string message)
		{
		}

		public void UseDialogueUI(GameObject gameObject)
		{
		}

		private IDialogueUI GetDialogueUI()
		{
			return null;
		}

		private void SetDialogueUI(IDialogueUI ui)
		{
		}

		private void ValidateCurrentDialogueUI()
		{
		}

		private void GetDialogueUIFromDisplaySettings()
		{
		}

		private IDialogueUI LoadDefaultDialogueUI()
		{
			return null;
		}

		private IDialogueUI LoadDialogueUIPrefab(GameObject prefab)
		{
			return null;
		}

		private Canvas GetOrCreateDefaultCanvas()
		{
			return null;
		}

		public void SetDialoguePanel(bool show, bool immediate = false)
		{
		}

		private Sequencer GetNewSequencer()
		{
			return null;
		}

		private void RegisterLuaFunctions()
		{
		}

		private void UnregisterLuaFunctions()
		{
		}

		public void SendUpdateTracker()
		{
		}

		public static void LuaShowAlert(string message)
		{
		}

		public static void LuaHideAlert()
		{
		}

		private static DialogueEntry GetDialogueEntryInCurrentConversation(double entryID)
		{
			return null;
		}

		private static string GetEntryText(double entryID, string fieldName)
		{
			return null;
		}

		private static bool GetEntryBool(double entryID, string fieldName)
		{
			return false;
		}

		private static double GetEntryNumber(double entryID, string fieldName)
		{
			return 0.0;
		}

		public void RandomizeNextEntry()
		{
		}

		public static string Conditional(bool condition, string value)
		{
			return null;
		}

		public static void ChangeActorName(string actorName, string newDisplayName)
		{
		}

		public static string ActorIDToName(double id)
		{
			return null;
		}

		public static string ItemIDToName(double id)
		{
			return null;
		}

		public void AddLuaObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		[IteratorStateMachine(typeof(_003CAddLuaObserverAfterStart_003Ed__278))]
		private IEnumerator AddLuaObserverAfterStart(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
			return null;
		}

		public void RemoveLuaObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		public void RemoveAllObservers(LuaWatchFrequency frequency)
		{
		}

		public void RemoveAllObservers()
		{
		}

		private void Update()
		{
		}

		private void UpdateTracker()
		{
		}

		public void RegisterAssetBundle(AssetBundle bundle)
		{
		}

		public void UnregisterAssetBundle(AssetBundle bundle)
		{
		}

		public UnityEngine.Object LoadAsset(string name)
		{
			return null;
		}

		public UnityEngine.Object LoadAsset(string name, Type type)
		{
			return null;
		}

		protected void AddDelegateForAssetBeingLoaded(string name, AssetLoadedDelegate assetLoaded)
		{
		}

		protected void RemoveDelegatesForAssetBeingLoaded(string name)
		{
		}

		protected void CallDelegatesForAssetBeingLoaded(string name, UnityEngine.Object asset)
		{
		}

		public void LoadAsset(string name, Type type, AssetLoadedDelegate assetLoaded)
		{
		}

		public void UnloadAsset(object obj)
		{
		}

		public void ClearLoadedAssetHashes()
		{
		}

		public void UnloadAssets()
		{
		}
	}
}

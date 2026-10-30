using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using PixelCrushers.DialogueSystem.SequencerCommands;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class Sequencer : MonoBehaviour
	{
		public delegate void MessageStringDelegate(string message);

		[CompilerGenerated]
		private sealed class _003CRestoreCamera_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Sequencer _003C_003E4__this;

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
			public _003CRestoreCamera_003Ed__118(int _003C_003E1__state)
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
		private sealed class _003CPlaySequenceAfterOneFrame_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Sequencer _003C_003E4__this;

			public string sequence;

			public Transform speaker;

			public Transform listener;

			public bool informParticipants;

			public bool destroyWhenDone;

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
			public _003CPlaySequenceAfterOneFrame_003Ed__133(int _003C_003E1__state)
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
		private sealed class _003CSendTimedSequencerMessage_003Ed__147 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Sequencer _003C_003E4__this;

			public float delay;

			public string guid;

			public string endMessage;

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
			public _003CSendTimedSequencerMessage_003Ed__147(int _003C_003E1__state)
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
		private sealed class _003CDestroyAfterOneFrame_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SequencerCommand command;

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
			public _003CDestroyAfterOneFrame_003Ed__157(int _003C_003E1__state)
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

		private const string DefaultCameraAnglesResourceName = "Default Camera Angles";

		public bool disableInternalSequencerCommands;

		private bool m_hasCameraControl;

		private Camera m_originalCamera;

		private Vector3 m_originalCameraPosition;

		private Quaternion m_originalCameraRotation;

		private float m_originalOrthographicSize;

		private bool m_keepCameraPositionOnClose;

		private Transform m_speaker;

		private Transform m_listener;

		private ConversationView m_conversationView;

		private List<QueuedSequencerCommand> m_queuedCommands;

		private List<SequencerCommand> m_activeCommands;

		private List<SequencerCommand> m_commandsToDelete;

		private float m_delayTimeLeft;

		private bool m_informParticipants;

		private bool m_closeWhenFinished;

		private Camera m_sequencerCameraSource;

		private Camera m_sequencerCamera;

		private GameObject m_alternateSequencerCameraObject;

		private GameObject m_cameraAngles;

		private bool m_isUsingMainCamera;

		private bool m_isPlaying;

		public static bool reportMissingAudioFiles;

		private static Dictionary<string, Type> m_cachedComponentTypes;

		private static Dictionary<string, string> m_shortcuts;

		private static Dictionary<string, Stack<string>> m_shortcutStack;

		private Dictionary<string, Coroutine> m_timedMessageCoroutines;

		private SequenceParser m_parser;

		private const float InstantThreshold = 0.001f;

		private static Regex ShortcutRegex;

		public static Sequencer s_awakeSequencer;

		public static string s_awakeEndMessage;

		public static Transform s_awakeSpeaker;

		public static Transform s_awakeListener;

		public static string[] s_awakeArgs;

		private List<string> queuedMessages;

		private List<int> m_setDialoguePanelPreviouslyOpenSubtitlePanels;

		private List<int> m_setDialoguePanelPreviouslyFocusedSubtitlePanels;

		private List<int> m_setDialoguePanelPreviouslyOpenMenuPanels;

		private List<bool> m_setDialoguePanelPreviousClearText;

		private List<bool> m_setDialoguePanelPreviousContinueButtonStates;

		private static DisplaySettings.SubtitleSettings.ContinueButtonMode savedContinueButtonMode;

		public bool isPlaying => false;

		public GameObject cameraAngles => null;

		public Camera sequencerCamera => null;

		public Transform sequencerCameraTransform => null;

		public Transform speaker => null;

		public Transform listener => null;

		public ConversationView conversationView
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 originalCameraPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion originalCameraRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public float originalOrthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool keepCameraPositionOnClose
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float subtitleEndTime { get; set; }

		public string entrytag { get; set; }

		public string entrytaglocal => null;

		public ActiveConversationRecord activeConversationRecord { get; set; }

		public bool IsPlaying => false;

		public GameObject CameraAngles => null;

		public Camera SequencerCamera => null;

		public Transform SequencerCameraTransform => null;

		public Transform Speaker => null;

		public Transform Listener => null;

		public Vector3 OriginalCameraPosition => default(Vector3);

		public Quaternion OriginalCameraRotation => default(Quaternion);

		public float OriginalOrthographicSize => 0f;

		public float SubtitleEndTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int numQueuedCommands => 0;

		public int numActiveCommands => 0;

		public static Dictionary<string, string> shortcuts => null;

		public static Dictionary<string, Stack<string>> shortcutStack => null;

		public event Action FinishedSequenceHandler
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

		public event MessageStringDelegate receivedMessage
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

		public static void Message(string message)
		{
		}

		public static void RegisterShortcut(string shortcut, string value)
		{
		}

		public static void UnregisterShortcut(string shortcut)
		{
		}

		public static string ReplaceShortcuts(string sequence)
		{
			return null;
		}

		private static void ReportUnrecognizedShortcuts(string sequence)
		{
		}

		public void UseCamera(Camera sequencerCamera, GameObject cameraAngles)
		{
		}

		public void UseCamera(Camera sequencerCamera, GameObject alternateSequencerCameraObject, GameObject cameraAngles)
		{
		}

		private void GetCameraAngles()
		{
		}

		private void GetCamera()
		{
		}

		private void DestroyCamera()
		{
		}

		[IteratorStateMachine(typeof(_003CRestoreCamera_003Ed__118))]
		private IEnumerator RestoreCamera()
		{
			return null;
		}

		public void SwitchCamera(Camera newCamera)
		{
		}

		public void TakeCameraControl()
		{
		}

		private void ReleaseCameraControl()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void OnDestroy()
		{
		}

		public void Update()
		{
		}

		private void FinishSequence()
		{
		}

		public void SetParticipants(Transform speaker, Transform listener)
		{
		}

		private void InformParticipants(string message)
		{
		}

		public void PlaySequence(string sequence)
		{
		}

		public void PlaySequence(string sequence, bool informParticipants, bool destroyWhenDone)
		{
		}

		public void PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
		}

		public void PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone, bool delayOneFrame)
		{
		}

		[IteratorStateMachine(typeof(_003CPlaySequenceAfterOneFrame_003Ed__133))]
		public IEnumerator PlaySequenceAfterOneFrame(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
			return null;
		}

		public void PlayCommand(string commandName, bool required, float time, string message, string endMessage, params string[] args)
		{
		}

		public void PlayCommand(QueuedSequencerCommand commandRecord)
		{
		}

		public void PlayCommand(QueuedSequencerCommand commandRecord, string commandName, bool required, float time, string message, string endMessage, params string[] args)
		{
		}

		private bool IsTimePaused()
		{
			return false;
		}

		private void ActivateCommand(string commandName, string endMessage, Transform speaker, Transform listener, string[] args)
		{
		}

		private Type FindSequencerCommandType(string commandName)
		{
			return null;
		}

		public static void Preload()
		{
		}

		public Type GetTypeFromName(string typeName)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSendTimedSequencerMessage_003Ed__147))]
		private IEnumerator SendTimedSequencerMessage(string endMessage, float delay, string guid)
		{
			return null;
		}

		private void ActivateCommand(QueuedSequencerCommand queuedCommand)
		{
		}

		private void CheckQueuedCommands()
		{
		}

		public void OnSequencerMessage(string message)
		{
		}

		private void CheckActiveCommands()
		{
		}

		public void Stop()
		{
		}

		private void StopTimedSequencerMessageCoroutines()
		{
		}

		public void StopQueued()
		{
		}

		public void StopActive()
		{
		}

		[IteratorStateMachine(typeof(_003CDestroyAfterOneFrame_003Ed__157))]
		private IEnumerator DestroyAfterOneFrame(SequencerCommand command)
		{
			return null;
		}

		private bool HandleCommandInternally(string commandName, string[] args, out float duration)
		{
			duration = default(float);
			return false;
		}

		private string GetParameters(string[] args)
		{
			return null;
		}

		private bool HandleDelayInternally(string commandName, string[] args, out float duration)
		{
			duration = default(float);
			return false;
		}

		private bool TryHandleCameraInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimationInternally(string commandName, string[] args, out float duration)
		{
			duration = default(float);
			return false;
		}

		private bool HandleAnimatorControllerInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleAnimatorLayerInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorBoolInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorIntInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleAnimatorFloatInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorTriggerInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorPlayInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAudioInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAudioStopInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleMoveToInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleLookAtInternally(string commandName, string[] args)
		{
			return false;
		}

		private void DoLookAt(Transform subject, Vector3 position, bool yAxisOnly)
		{
		}

		private bool HandleNavMeshAgentInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSendMessageInternally(string commandName, bool upwards, string[] args)
		{
			return false;
		}

		private bool HandleSetActiveInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetEnabledInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleClearSubtitleText(string commandName, string[] args)
		{
			return false;
		}

		public void SetDialoguePanel(bool show, bool immediate)
		{
		}

		private bool HandleSetDialoguePanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleOpenPanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleHidePanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetPanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetMenuPanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetPortraitInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetTimeoutInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetContinueModeInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryGetContinueMode(string arg, out DisplaySettings.SubtitleSettings.ContinueButtonMode mode)
		{
			mode = default(DisplaySettings.SubtitleSettings.ContinueButtonMode);
			return false;
		}

		private bool HandleContinueInternally(string[] args)
		{
			return false;
		}

		private bool HandleSetVariableInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleShowAlertInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleUpdateTrackerInternally()
		{
			return false;
		}

		private bool HandleRandomizeNextEntryInternally()
		{
			return false;
		}

		private bool HandleStopConversationInternally()
		{
			return false;
		}

		private bool HandleSequencerMessageInternally(string commandName, string[] args)
		{
			return false;
		}
	}
}

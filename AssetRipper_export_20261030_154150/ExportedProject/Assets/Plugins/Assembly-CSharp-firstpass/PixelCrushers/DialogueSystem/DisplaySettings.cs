using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class DisplaySettings
	{
		[Serializable]
		public class LocalizationSettings
		{
			[Tooltip("Current language, or blank to use the default language.")]
			public string language;

			[Tooltip("Use the system language at startup.")]
			public bool useSystemLanguage;

			[Tooltip("Optional localized text for alerts and other general text. Note: Now uses Text Table instead of Localized Text Table.")]
			public TextTable textTable;
		}

		[Serializable]
		public class SubtitleSettings
		{
			public enum ContinueButtonMode
			{
				Never = 0,
				Always = 1,
				Optional = 2,
				OptionalBeforeResponseMenu = 3,
				NotBeforeResponseMenu = 4,
				OptionalBeforePCAutoresponseOrMenu = 5,
				NotBeforePCAutoresponseOrMenu = 6,
				OptionalForPC = 7,
				NotForPC = 8,
				OptionalForPCOrBeforeResponseMenu = 9,
				NotForPCOrBeforeResponseMenu = 10,
				OptionalForPCOrBeforePCAutoresponseOrMenu = 11,
				NotForPCOrBeforePCAutoresponseOrMenu = 12,
				OnlyForPC = 13
			}

			[Tooltip("Show NPC subtitle text while NPC speaks a line of dialogue.")]
			public bool showNPCSubtitlesDuringLine;

			[Tooltip("Show NPC subtitle reminder text while showing the player response menu. If you're using Standard Dialogue UI, the subtitle panel's Visiblity value takes precedenece over this.")]
			public bool showNPCSubtitlesWithResponses;

			[Tooltip("Show PC subtitle text while PC speaks a line of dialogue. If Skip PC Subtitle After Response Menu (below) is ticked, PC subtitles from response menu selections will be skipped.")]
			public bool showPCSubtitlesDuringLine;

			[Tooltip("Allow PC subtitles to be used for reminder text while showing the response menu.")]
			public bool allowPCSubtitleReminders;

			[Tooltip("If the PC's subtitle came from a response menu selection, don't show the subtitle even if Show PC Subtitles During Line is ticked.")]
			public bool skipPCSubtitleAfterResponseMenu;

			[Tooltip("Used to compute default duration to display subtitle. Typewriter effects have their own separate setting.")]
			public float subtitleCharsPerSecond;

			[Tooltip("Minimum default duration to display subtitle.")]
			public float minSubtitleSeconds;

			[Tooltip("How to handle continue buttons.")]
			public ContinueButtonMode continueButton;

			[Tooltip("If ticked, always require continue button on subtitle that ends conversation. Overrides Continue Button dropdown above.")]
			public bool requireContinueOnLastLine;

			[Tooltip("Use rich text codes for [em#] markup tags. If unticked, [em#] tag will apply color to entire text.")]
			public bool richTextEmphases;

			[Tooltip("Send OnSequenceStart and OnSequenceEnd messages with every dialogue entry's sequence.")]
			public bool informSequenceStartAndEnd;
		}

		[Serializable]
		public class CameraSettings
		{
			[Tooltip("Camera or prefab to use for sequences. If unassigned, sequences use the current main camera.")]
			public Camera sequencerCamera;

			[Tooltip("If assigned, use instead of Sequencer Camera -- for example, Oculus VR GameObject. Can't be a prefab.")]
			public GameObject alternateCameraObject;

			[Tooltip("Camera angle object or prefab. If unassigned, use default camera angle definitions.")]
			public GameObject cameraAngles;

			[Tooltip("If conversation's sequences use Main Camera, leave camera in current position at end of conversation instead of restoring pre-conversation position.")]
			public bool keepCameraPositionAtConversationEnd;

			[Tooltip("Used when a dialogue entry doesn't define its own Sequence. Set to Delay({{end}}) to leave the camera untouched.")]
			[TextArea]
			public string defaultSequence;

			[Tooltip("If defined, overrides Default Sequence for player (PC) lines only.")]
			[TextArea]
			public string defaultPlayerSequence;

			[Tooltip("Used when a dialogue entry doesn't define its own Response Menu Sequence.")]
			[TextArea]
			public string defaultResponseMenuSequence;

			[Tooltip("Format to use for the 'entrytag' keyword.")]
			public EntrytagFormat entrytagFormat;

			[Tooltip("By default, Audio() and AudioWait() sequencer commands don't report missing audio files to reduce Console spam during development.")]
			public bool reportMissingAudioFiles;

			[HideInInspector]
			public bool disableInternalSequencerCommands;
		}

		[Serializable]
		public class InputSettings
		{
			[Tooltip("Show the response menu even if there's only one response.")]
			public bool alwaysForceResponseMenu;

			[Tooltip("Include responses whose Conditions are false. typically shown in a disabled state.")]
			public bool includeInvalidEntries;

			[Tooltip("If nonzero, the duration in seconds until the response menu times out.")]
			public float responseTimeout;

			[Tooltip("What to do if the response menu times out.")]
			public ResponseTimeoutAction responseTimeoutAction;

			[Tooltip("The [em#] tag to wrap around responses that have been previously chosen.")]
			public EmTag emTagForOldResponses;

			[Tooltip("The [em#] tag to wrap around invalid responses. These responses are only shown if Include Invalid Entries is ticked.")]
			public EmTag emTagForInvalidResponses;

			[Tooltip("Input buttons mapped to QTEs.")]
			public string[] qteButtons;

			[Tooltip("Key or button that cancels subtitle sequences.")]
			public InputTrigger cancel;

			[Tooltip("Key or button that cancels active conversation while in response menu.")]
			public InputTrigger cancelConversation;
		}

		[Serializable]
		public class BarkSettings
		{
			[Tooltip("Allow barks to play during conversations.")]
			public bool allowBarksDuringConversations;

			[Tooltip("Show barks for this many characters per second. If zero, use Subtitle Settings > Subtitle Chars Per Second.")]
			public float barkCharsPerSecond;

			[Tooltip("Show barks  for at least this many seconds. If zero, use Subtitle Settings > Min Subtitle Seconds.")]
			public float minBarkSeconds;

			[Tooltip("If non-blank, play this sequence with barks that don't specify their own Sequence.")]
			public string defaultBarkSequence;
		}

		[Serializable]
		public class AlertSettings
		{
			[Tooltip("Allow the dialogue UI to show alerts during conversations.")]
			public bool allowAlertsDuringConversations;

			[Tooltip("If nonzero, check Variable['Alert'] at this frequency to show alert messages.")]
			public float alertCheckFrequency;

			[Tooltip("Show alerts for this many characters per second. If zero, use Subtitle Settings > Subtitle Chars Per Second.")]
			public float alertCharsPerSecond;

			[Tooltip("Show alerts for at least this many seconds. If zero, use Subtitle Settings > Min Subtitle Seconds.")]
			public float minAlertSeconds;
		}

		[HideInInspector]
		public ConversationOverrideDisplaySettings conversationOverrideSettings;

		[Tooltip("Assign a GameObject that contains an active dialogue UI component. Can be a prefab. If unassigned, Dialogue Manager will search its children for an active dialogue UI component.")]
		public GameObject dialogueUI;

		[Tooltip("Optional. Assign Canvas into which dialogue UI will be instantiated if it's a prefab.")]
		public Canvas defaultCanvas;

		public LocalizationSettings localizationSettings;

		public SubtitleSettings subtitleSettings;

		public CameraSettings cameraSettings;

		public InputSettings inputSettings;

		public BarkSettings barkSettings;

		public AlertSettings alertSettings;

		public bool ShouldUseOverrides()
		{
			return false;
		}

		public bool ShouldUseSubtitleOverrides()
		{
			return false;
		}

		public bool GetShowNPCSubtitlesDuringLine()
		{
			return false;
		}

		public bool GetShowNPCSubtitlesWithResponses()
		{
			return false;
		}

		public bool GetShowPCSubtitlesDuringLine()
		{
			return false;
		}

		public bool GetSkipPCSubtitleAfterResponseMenu()
		{
			return false;
		}

		public float GetSubtitleCharsPerSecond()
		{
			return 0f;
		}

		public float GetMinSubtitleSeconds()
		{
			return 0f;
		}

		public SubtitleSettings.ContinueButtonMode GetContinueButtonMode()
		{
			return default(SubtitleSettings.ContinueButtonMode);
		}

		public bool ShouldUseSequenceOverrides()
		{
			return false;
		}

		public string GetDefaultSequence()
		{
			return null;
		}

		public string GetDefaultPlayerSequence()
		{
			return null;
		}

		public string GetDefaultResponseMenuSequence()
		{
			return null;
		}

		public bool ShouldUseInputOverrides()
		{
			return false;
		}

		public bool GetAlwaysForceResponseMenu()
		{
			return false;
		}

		public bool GetIncludeInvalidEntries()
		{
			return false;
		}

		public float GetResponseTimeout()
		{
			return 0f;
		}

		public EmTag GetEmTagForOldResponses()
		{
			return default(EmTag);
		}

		public EmTag GetEmTagForInvalidResponses()
		{
			return default(EmTag);
		}

		public InputTrigger GetCancelSubtitleInput()
		{
			return null;
		}

		public InputTrigger GetCancelConversationInput()
		{
			return null;
		}
	}
}

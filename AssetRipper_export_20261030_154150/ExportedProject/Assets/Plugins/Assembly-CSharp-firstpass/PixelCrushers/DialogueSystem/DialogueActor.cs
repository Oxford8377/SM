using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class DialogueActor : MonoBehaviour
	{
		[Serializable]
		public class BarkUISettings
		{
			[Tooltip("If a prefab, Dialogue Actor will instantiate it at runtime.")]
			public AbstractBarkUI barkUI;

			[Tooltip("If instantiating bark UI prefab, offset it this far from Dialogue Actor's origin.")]
			public Vector3 barkUIOffset;
		}

		public enum UseMenuPanelFor
		{
			OnlyMe = 0,
			MeAndResponsesToMe = 1
		}

		[Serializable]
		public class StandardDialogueUISettings
		{
			[Tooltip("If using Standard Dialogue UI, subtitle panel to use for this actor.")]
			public SubtitlePanelNumber subtitlePanelNumber;

			[Tooltip("The panel to use if Subtitle Panel Number is set to Custom.")]
			public StandardUISubtitlePanel customSubtitlePanel;

			[Tooltip("If instantiating subtitle panel prefab, offset it this far from Dialogue Actor's origin.")]
			public Vector3 customSubtitlePanelOffset;

			[Tooltip("If using Standard Dialogue UI, menu panel to use for this actor.")]
			public MenuPanelNumber menuPanelNumber;

			[Tooltip("The panel to use if Menu Panel Number is set to Custom.")]
			public StandardUIMenuPanel customMenuPanel;

			[Tooltip("If instantiating menu panel prefab, offset it this far from Dialogue Actor's origin.")]
			public Vector3 customMenuPanelOffset;

			[Tooltip("If Only Me, only use this menu panel when this Dialogue Actor is the respondent.\nIf MeAndResponsesToMe, use this menu panel when this Dialogue Actor is the response or the character being responded to (i.e., the last one to speak).")]
			public UseMenuPanelFor useMenuPanelFor;

			[Tooltip("If assigned, animator controller that runs this actor's animated portrait. It should animate an Image component, not a SpriteRenderer.")]
			public RuntimeAnimatorController portraitAnimatorController;

			[Tooltip("Specify subtitle color for this actor.")]
			public bool setSubtitleColor;

			[Tooltip("Prepend actor name and apply color only to name.")]
			public bool applyColorToPrependedName;

			[Tooltip("If prepending actor name, separate from Dialogue Text with this string.")]
			public string prependActorNameSeparator;

			[Tooltip("If prepending actor name, format this way, where {0} is name + separator, and {1} is Dialogue Text.")]
			public string prependActorNameFormat;

			[Tooltip("Color to use for this actor's subtitles.")]
			public Color subtitleColor;
		}

		[Tooltip("Use this actor name in conversations.")]
		[ActorPopup(true)]
		[FormerlySerializedAs("overrideName")]
		public string actor;

		[Tooltip("Name used when saving persistent data. If blank, use actor name.")]
		[FormerlySerializedAs("internalName")]
		public string persistentDataName;

		[Tooltip("Optional portrait. If unassigned, will use portrait of actor in database. This field allows you to assign a Texture.")]
		public Texture2D portrait;

		[Tooltip("Optional portrait. If unassigned, will use portrait of actor in database. This field allows you to assign a Sprite.")]
		public Sprite spritePortrait;

		public BarkUISettings barkUISettings;

		public StandardDialogueUISettings standardDialogueUISettings;

		protected virtual void Awake()
		{
		}

		public virtual Sprite GetPortraitSprite()
		{
			return null;
		}

		protected virtual void SetupBarkUI()
		{
		}

		protected virtual void SetupDialoguePanels()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual string GetName()
		{
			return null;
		}

		public virtual string GetActorName()
		{
			return null;
		}

		public virtual string GetPersistentDataName()
		{
			return null;
		}

		public virtual SubtitlePanelNumber GetSubtitlePanelNumber()
		{
			return default(SubtitlePanelNumber);
		}

		public virtual void SetSubtitlePanelNumber(SubtitlePanelNumber newSubtitlePanelNumber)
		{
		}

		public virtual MenuPanelNumber GetMenuPanelNumber()
		{
			return default(MenuPanelNumber);
		}

		public virtual void SetMenuPanelNumber(MenuPanelNumber newMenuPanelNumber)
		{
		}

		public virtual string AdjustSubtitleColor(Subtitle subtitle)
		{
			return null;
		}

		public static DialogueActor GetDialogueActorComponent(Transform t)
		{
			return null;
		}

		public static string GetActorName(Transform t)
		{
			return null;
		}

		public static string GetPersistentDataName(Transform t)
		{
			return null;
		}

		public static SubtitlePanelNumber GetSubtitlePanelNumber(Transform t)
		{
			return default(SubtitlePanelNumber);
		}

		public static IBarkUI GetBarkUI(Transform t)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ProximitySelector : MonoBehaviour
	{
		[Serializable]
		public class Reticle
		{
			public Texture2D inRange;

			public Texture2D outOfRange;

			public float width;

			public float height;
		}

		[Tooltip("Use a default OnGUI to display selection message and targeting reticle.")]
		public bool useDefaultGUI;

		[Tooltip("GUI skin to use for the target's information (name and use message).")]
		public GUISkin guiSkin;

		[Tooltip("Name of the GUI style in the skin.")]
		public string guiStyleName;

		public TextAnchor alignment;

		[Tooltip("Color of the information labels when the target is in range.")]
		public Color color;

		public TextStyle textStyle;

		[Tooltip("Color of the text style's outline or shadow.")]
		public Color textStyleColor;

		[Tooltip("Default use message. This can be overridden in the target's Usable component.")]
		public string defaultUseMessage;

		[Tooltip("Key that sends an OnUse message.")]
		public KeyCode useKey;

		[Tooltip("Input button that sends an OnUse message.")]
		public string useButton;

		[Tooltip("Enable touch triggering.")]
		public bool enableTouch;

		public ScaledRect touchArea;

		[Tooltip("Broadcast OnUse message to Usable object's children.")]
		public bool broadcastToChildren;

		[Tooltip("Actor transform to send with OnUse. Defaults to this transform.")]
		public Transform actorTransform;

		public UsableUnityEvent onSelectedUsable;

		public UsableUnityEvent onDeselectedUsable;

		protected List<Usable> usablesInRange;

		protected Usable currentUsable;

		protected string currentHeading;

		protected string currentUseMessage;

		protected bool toldListenersHaveUsable;

		protected GUIStyle guiStyle;

		protected float guiStyleLineHeight;

		protected const float MinTimeBetweenUseButton = 0.5f;

		protected float timeToEnableUseButton;

		public Usable CurrentUsable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyle GuiStyle => null;

		public event SelectedUsableObjectDelegate SelectedUsableObject
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

		public event DeselectedUsableObjectDelegate DeselectedUsableObject
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

		public event Action Enabled
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

		public event Action Disabled
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

		protected virtual void Reset()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void OnConversationStart(Transform actor)
		{
		}

		public virtual void OnConversationEnd(Transform actor)
		{
		}

		protected virtual void Update()
		{
		}

		protected void OnSelectedUsableObject(Usable usable)
		{
		}

		protected void OnDeselectedUsableObject(Usable usable)
		{
		}

		public virtual void UseCurrentSelection()
		{
		}

		protected virtual bool IsUseButtonDown()
		{
			return false;
		}

		protected bool IsTouchDown()
		{
			return false;
		}

		protected void OnTriggerEnter(Collider other)
		{
		}

		protected void OnTriggerExit(Collider other)
		{
		}

		protected virtual void CheckTriggerEnter(GameObject other)
		{
		}

		protected virtual void CheckTriggerExit(GameObject other)
		{
		}

		public virtual void RemoveGameObjectFromDetectedList(GameObject other)
		{
		}

		public virtual void RemoveUsableFromDetectedList(Usable usable)
		{
		}

		public virtual void SetCurrentUsable(Usable usable)
		{
		}

		protected virtual void OnUsableDisabled(Usable usable)
		{
		}

		public virtual void OnGUI()
		{
		}

		protected void SetGuiStyle()
		{
		}
	}
}

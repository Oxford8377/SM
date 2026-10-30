using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class Selector : MonoBehaviour
	{
		[Serializable]
		public class Reticle
		{
			public Texture2D inRange;

			public Texture2D outOfRange;

			public float width;

			public float height;
		}

		public enum SelectAt
		{
			CenterOfScreen = 0,
			MousePosition = 1,
			CustomPosition = 2
		}

		public enum DistanceFrom
		{
			Camera = 0,
			GameObject = 1,
			ActorTransform = 2
		}

		public enum Dimension
		{
			In2D = 0,
			In3D = 1
		}

		private static LayerMask DefaultLayer;

		[Tooltip("How to target. This is where the raycast points to.")]
		public SelectAt selectAt;

		[Tooltip("Layer mask to use when targeting objects; objects on others layers are ignored.")]
		public LayerMask layerMask;

		[Tooltip("How to compute range to targeted object.")]
		public DistanceFrom distanceFrom;

		[Tooltip("Don't target objects farther than this; targets may still be unusable if beyond their usable range.")]
		public float maxSelectionDistance;

		public Dimension runRaycasts;

		[Tooltip("Check all objects within raycast range for usables, even passing through obstacles.")]
		public bool raycastAll;

		[Tooltip(null)]
		public bool useDefaultGUI;

		[Tooltip("GUI skin to use for the target's information (name and use message).")]
		public GUISkin guiSkin;

		[Tooltip("Name of the GUI style in the skin.")]
		public string guiStyleName;

		public TextAnchor alignment;

		public TextStyle textStyle;

		public Color textStyleColor;

		[Tooltip("Color of the information labels when target is in range.")]
		public Color inRangeColor;

		[Tooltip("Color of the information labels when target is out of range.")]
		public Color outOfRangeColor;

		public Reticle reticle;

		public KeyCode useKey;

		public string useButton;

		[Tooltip("Default use message; can be overridden in the target's Usable component")]
		public string defaultUseMessage;

		[Tooltip("Tick to also broadcast to the usable object's children")]
		public bool broadcastToChildren;

		[Tooltip("Actor transform to send with OnUse; defaults to this transform")]
		public Transform actorTransform;

		[Tooltip("If set, show this alert message if attempt to use something beyond its usable range")]
		public string tooFarMessage;

		public UsableUnityEvent onSelectedUsable;

		public UsableUnityEvent onDeselectedUsable;

		public UnityEvent tooFarEvent;

		[Tooltip("Tick to draw gizmos in Scene view")]
		public bool debug;

		protected GameObject selection;

		protected Usable usable;

		protected GameObject clickedDownOn;

		protected string heading;

		protected string useMessage;

		protected float distance;

		protected GUIStyle guiStyle;

		protected float guiStyleLineHeight;

		protected Ray lastRay;

		protected RaycastHit lastHit;

		protected RaycastHit[] lastHits;

		protected int numLastHits;

		protected const int MaxHits = 100;

		protected bool hasReportedInvalidCamera;

		protected bool hasCheckedDefaultInputManager;

		protected bool isUsingDefaultInputManager;

		public Vector3 CustomPosition { get; set; }

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

		public float CurrentDistance => 0f;

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

		protected virtual void Update()
		{
		}

		public virtual void UseCurrentSelection()
		{
		}

		protected virtual void Run2DRaycast()
		{
		}

		protected virtual void Run3DRaycast()
		{
		}

		public virtual void SetCurrentUsable(Usable usable)
		{
		}

		protected void OnSelectedUsableObject(Usable usable)
		{
		}

		protected void OnDeselectedUsableObject(Usable usable)
		{
		}

		protected virtual void DeselectTarget()
		{
		}

		protected virtual void OnUsableDisabled(Usable usable)
		{
		}

		protected virtual bool IsUseButtonDown()
		{
			return false;
		}

		protected virtual bool IsUsingDefaultInputManager()
		{
			return false;
		}

		protected virtual Vector3 GetSelectionPoint()
		{
			return default(Vector3);
		}

		public virtual void OnGUI()
		{
		}

		protected void SetGuiStyle()
		{
		}

		public virtual void OnDrawGizmos()
		{
		}
	}
}

using UnityEngine;

namespace HinputClasses
{
	public class Settings : MonoBehaviour
	{
		public enum DefaultPressTypes
		{
			SimplePress = 0,
			DoublePress = 1,
			LongPress = 2
		}

		public enum DefaultPressFeatures
		{
			Pressed = 0,
			JustPressed = 1,
			Released = 2,
			JustReleased = 3
		}

		public enum StickTypes
		{
			FourDirections = 90,
			EightDirections = 45
		}

		private static Settings _instance;

		[Tooltip("The default conversion of Pressable to Press values\n\nDetermines how Hinput interprets buttons, triggers and stick directions when the type of Press to use is not specified")]
		[Header("Implicit Conversion")]
		[SerializeField]
		private DefaultPressTypes _defaultPressType;

		[SerializeField]
		[Tooltip("The default conversion of Press and Pressable to boolean values\n\nDetermines how Hinput interprets buttons, triggers and stick directions when the feature to use is not specified.")]
		private DefaultPressFeatures _defaultPressFeature;

		[Tooltip("The maximum duration between the start of two presses for them to be considered a double press.")]
		[Range(0f, 2f)]
		[SerializeField]
		[Header("Presses")]
		private float _doublePressDuration;

		[Tooltip("The minimum duration of a press for it to be considered a long press.")]
		[Range(0f, 2f)]
		[SerializeField]
		private float _longPressDuration;

		[Tooltip("The type of stick to use.\n\n- Set it to Four Directions for 4-directional sticks, with virtual buttons that span 1/4 of a circle (90 degrees). Use diagonals with caution in this case.\n\n- Set it to Eight Directions for 8-directional sticks, with virtual buttons that span 1/8 of a circle (45 degrees).")]
		[SerializeField]
		[Header("Sticks")]
		private StickTypes _stickType;

		[Tooltip("The distance from the origin beyond which stick inputs start being registered.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _stickDeadZone;

		[Tooltip("The distance from the end of the dead zone beyond which stick inputs are considered pushed.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stickPressedZone;

		[Tooltip("The Camera on which the worldPositionCamera feature of Stick should be based. If no Camera is set, Hinput will try to find one on the scene.")]
		[SerializeField]
		private Transform _worldCamera;

		[Tooltip("The distance from the origin beyond which trigger inputs start being registered.")]
		[Range(0f, 1f)]
		[SerializeField]
		[Header("Triggers")]
		private float _triggerDeadZone;

		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("The distance from the end of the dead zone beyond which trigger inputs are considered pushed.")]
		private float _triggerPressedZone;

		[Header("Vibration Defaults")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The default intensity of the left (low-frequency) motor when controllers vibrate.\n\nThe left motor's vibration feels like a low rumble.")]
		private float _vibrationDefaultLeftIntensity;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The default intensity of the right (high-frequency) motor when controllers vibrate.\n\nThe right motor's vibration feels like a sharp buzz.")]
		private float _vibrationDefaultRightIntensity;

		[Tooltip("The default duration of gamepad vibrations.")]
		[Range(0f, 2f)]
		[SerializeField]
		private float _vibrationDefaultDuration;

		[SerializeField]
		[Header("Performance")]
		[Tooltip("The maximum amount of gamepads to be tracked by Hinput.\n\nReducing this before entering play mode may improve performance.")]
		[Range(0f, 8f)]
		private int _amountOfGamepads;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the AnyGamepad feature to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableAnyGamepad;

		[Tooltip("Checking this before entering play mode will cause the A button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		[SerializeField]
		private bool _disableA;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the B button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableB;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the X button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableX;

		[Tooltip("Checking this before entering play mode will cause the Y button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		[SerializeField]
		private bool _disableY;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the left bumper of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableLeftBumper;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the right bumper of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableRightBumper;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the left trigger of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableLeftTrigger;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the right trigger of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableRightTrigger;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the back button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableBack;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the start button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableStart;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the left stick click of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableLeftStickClick;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the right stick click of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableRightStickClick;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the xBox button of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableXBoxButton;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the left stick of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableLeftStick;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the right stick of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableRightStick;

		[Tooltip("Checking this before entering play mode will cause the D-pad of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		[SerializeField]
		private bool _disableDPad;

		[SerializeField]
		[Tooltip("Checking this before entering play mode will cause the AnyInput feature of gamepads to not be tracked by Hinput. \n\nThis may improve performance.")]
		private bool _disableAnyInput;

		public static Settings instance => null;

		public static DefaultPressTypes defaultPressType
		{
			get
			{
				return default(DefaultPressTypes);
			}
			set
			{
			}
		}

		public static DefaultPressFeatures defaultPressFeature
		{
			get
			{
				return default(DefaultPressFeatures);
			}
			set
			{
			}
		}

		public static float doublePressDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float longPressDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static StickTypes stickType
		{
			get
			{
				return default(StickTypes);
			}
			set
			{
			}
		}

		public static float stickDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float stickPressedZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Transform worldCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static float triggerDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float triggerPressedZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float vibrationDefaultLeftIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float vibrationDefaultRightIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float vibrationDefaultDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int amountOfGamepads
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool disableAnyGamepad
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableA
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableB
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableLeftBumper
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableRightBumper
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableLeftTrigger
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableRightTrigger
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableBack
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableLeftStickClick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableRightStickClick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableXBoxButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableLeftStick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableRightStick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableDPad
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool disableAnyInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static void CheckInstance()
		{
		}

		private void Awake()
		{
		}
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace HinputClasses.Internal
{
	public class Debugger : MonoBehaviour
	{
		public enum SD
		{
			none = 0,
			verticalsAndHorizontals = 1,
			diagonals = 2,
			pressedZone = 3
		}

		public enum BF
		{
			none = 0,
			defaultCast = 1,
			simplePress = 2,
			doublePress = 3,
			longPress = 4,
			triggerPosition = 5
		}

		public enum PF
		{
			defaultCast = 0,
			justPressedAndJustReleased = 1,
			pressedAndReleased = 2,
			pressDurationAndReleaseDuration = 3
		}

		public enum SF
		{
			none = 0,
			position = 1,
			horizontal = 2,
			vertical = 3,
			angle = 4,
			distance = 5,
			worldPositionCamera = 6,
			worldPositionFlat = 7
		}

		public enum GM
		{
			individualGamepads = 0,
			anyGamepad = 1
		}

		public enum IM
		{
			individualInputs = 0,
			anyInput = 1
		}

		public enum VM
		{
			noArgs = 0,
			duration = 1,
			intensity = 2,
			durationAndIntensity = 3,
			oneCurve = 4,
			twoCurves = 5,
			vibrationPreset = 6,
			advanced = 7
		}

		[Header("GENERAL")]
		public bool startMessage;

		public bool lockCurrentInput;

		[Header("BUTTONS")]
		public SD stickDirections;

		public BF buttonFeature;

		public PF pressFeature;

		[Header("STICKS")]
		public SF stickFeature;

		[Header("VIBRATION")]
		public bool vibrateOnVPressed;

		[Header("TIME")]
		[Space(20f)]
		[Header("--------------------")]
		[Space(20f)]
		[Range(0f, 3f)]
		public float timeScale;

		public bool playInUpdate;

		public bool playInFixedUpdate;

		[Header("GAMEPAD AND INPUT MODE")]
		public GM gamepadMode;

		public IM inputMode;

		[Header("INFO")]
		public bool gamepadInfoOnGPressed;

		public bool gamepadListsOnLPressed;

		public bool stickInfoOnPPressed;

		public bool buttonInfoOnBPressed;

		[Header("ENABLE/DISABLE")]
		public bool toggleGamepadOnGPressed;

		public bool toggleStickOnPPressed;

		public bool toggleButtonOnBPressed;

		[Header("VIBRATION")]
		[Range(0f, 7f)]
		public int gamepadToVibrate;

		public VM vibrationMode;

		[Range(0f, 10f)]
		public float duration;

		[Range(0f, 1f)]
		public float leftIntensity;

		[Range(0f, 1f)]
		public float rightIntensity;

		public AnimationCurve curve;

		public AnimationCurve leftCurve;

		public AnimationCurve rightCurve;

		public VibrationPreset vibrationPreset;

		public bool multiplyVibrationPreset;

		public bool stopVibrationOnSPressed;

		[Range(-1f, 3f)]
		public float stopVibrationDuration;

		public bool displayIntensity;

		[Header("REFERENCES")]
		[Space(20f)]
		[Header("--------------------")]
		[Space(20f)]
		public GameObject message;

		public Transform plane;

		public Transform redCube;

		public Transform blueSphere;

		public float moveSpeed;

		private Stick currentStick;

		private Pressable currentButton;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void TestEverything()
		{
		}

		private void TestInfo()
		{
		}

		private void TestEnableDisable()
		{
		}

		private void TestButtons()
		{
		}

		private void GetNewCurrentButton()
		{
		}

		private List<Pressable> AllGamepadButtons(Gamepad gamepad)
		{
			return null;
		}

		private void TestCurrentButton()
		{
		}

		private void TestSticks()
		{
		}

		private void GetNewCurrentStick()
		{
		}

		private void UpdateCurrentStickFromGamepad(Gamepad gamepad)
		{
		}

		private void TestCurrentStick()
		{
		}

		private void TestVibration()
		{
		}

		private void TestVibrationOnGamepad(Gamepad gamepad)
		{
		}

		private static string ToString<T>(List<T> list)
		{
			return null;
		}
	}
}

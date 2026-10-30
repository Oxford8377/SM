using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class InputDeviceManager : MonoBehaviour
	{
		public enum KeyInputSwitchesModeTo
		{
			Keyboard = 0,
			Mouse = 1
		}

		public delegate bool GetButtonDownDelegate(string buttonName);

		public delegate float GetAxisDelegate(string axisName);

		[CompilerGenerated]
		private sealed class _003CBrieflyIgnoreMouseMovementCoroutine_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InputDeviceManager _003C_003E4__this;

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
			public _003CBrieflyIgnoreMouseMovementCoroutine_003Ed__62(int _003C_003E1__state)
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
		private sealed class _003CForceCursorAfterOneFrameCoroutine_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool visible;

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
			public _003CForceCursorAfterOneFrameCoroutine_003Ed__67(int _003C_003E1__state)
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

		[Tooltip("Current input mode.")]
		public InputDevice inputDevice;

		[Tooltip("If any of these keycodes are pressed, current device is joystick.")]
		public KeyCode[] joystickKeyCodesToCheck;

		[Tooltip("If any of these buttons are pressed, current device is joystick. Must be defined in Input Manager.")]
		public string[] joystickButtonsToCheck;

		[Tooltip("If any of these axes are greater than Joystick Axis Threshold, current device is joystick. Must be defined in Input Manager.")]
		public string[] joystickAxesToCheck;

		[Tooltip("Joystick axis values must be above this threshold to switch to joystick mode.")]
		public float joystickAxisThreshold;

		[Tooltip("If any of these buttons are pressed, current device is keyboard (unless device is currently mouse).")]
		public string[] keyButtonsToCheck;

		[Tooltip("If any of these keys are pressed, current device is keyboard (unless device is currently mouse).")]
		public KeyCode[] keyCodesToCheck;

		[Tooltip("Which mode to switch to if user presses Key Buttons/Codes To Check.")]
		public KeyInputSwitchesModeTo keyInputSwitchesModeTo;

		[Tooltip("Always enable joystick/keyboard navigation even in Mouse mode.")]
		public bool alwaysAutoFocus;

		[Tooltip("Switch to mouse control if player clicks mouse buttons or moves mouse.")]
		public bool detectMouseControl;

		[Tooltip("If mouse moves more than this, current device is mouse.")]
		public float mouseMoveThreshold;

		[Tooltip("Hide cursor in joystick/key mode, show in mouse mode.")]
		public bool controlCursorState;

		[Tooltip("When paused and device is mouse, make sure cursor is visible.")]
		public bool enforceCursorOnPause;

		[Tooltip("Enable GraphicRaycasters (which detect cursor clicks on UI elements) only when device is mouse.")]
		public bool controlGraphicRaycasters;

		[Tooltip("If any of these keycodes are pressed, go back to the previous menu.")]
		public KeyCode[] backKeyCodes;

		[Tooltip("If any of these buttons are pressed, go back to the previous menu.")]
		public string[] backButtons;

		[Tooltip("'Submit' input button defined on Event System.")]
		public string submitButton;

		[Tooltip("Survive scene changes and only allow one instance.")]
		public bool singleton;

		public UnityEvent onUseKeyboard;

		public UnityEvent onUseJoystick;

		public UnityEvent onUseMouse;

		public UnityEvent onUseTouch;

		public GetButtonDownDelegate GetButtonDown;

		public GetButtonDownDelegate GetButtonUp;

		public GetAxisDelegate GetInputAxis;

		private Vector3 m_lastMousePosition;

		private bool m_ignoreMouse;

		private bool m_inputAllowed;

		private static InputDeviceManager m_instance;

		public static InputDeviceManager instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static InputDevice currentInputDevice => default(InputDevice);

		public static bool deviceUsesCursor => false;

		public static bool autoFocus => false;

		public static bool isBackButtonDown => false;

		public static bool isInputAllowed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsButtonDown(string buttonName)
		{
			return false;
		}

		public static bool IsButtonUp(string buttonName)
		{
			return false;
		}

		public static bool IsKeyDown(KeyCode keyCode)
		{
			return false;
		}

		public static bool IsAnyKeyDown()
		{
			return false;
		}

		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		public static Vector3 GetMousePosition()
		{
			return default(Vector3);
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void Start()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public void SetInputDevice(InputDevice newDevice)
		{
		}

		private void SetGraphicRaycasters(bool deviceUsesCursor)
		{
		}

		public void Update()
		{
		}

		public bool IsUsingJoystick()
		{
			return false;
		}

		public bool IsUsingMouse()
		{
			return false;
		}

		public void BrieflyIgnoreMouseMovement()
		{
		}

		[IteratorStateMachine(typeof(_003CBrieflyIgnoreMouseMovementCoroutine_003Ed__62))]
		private IEnumerator BrieflyIgnoreMouseMovementCoroutine()
		{
			return null;
		}

		public bool IsUsingKeyboard()
		{
			return false;
		}

		public bool IsBackButtonDown()
		{
			return false;
		}

		public void SetCursor(bool visible)
		{
		}

		public void ForceCursor(bool visible)
		{
		}

		[IteratorStateMachine(typeof(_003CForceCursorAfterOneFrameCoroutine_003Ed__67))]
		private IEnumerator ForceCursorAfterOneFrameCoroutine(bool visible)
		{
			return null;
		}

		public static bool DefaultGetKeyDown(KeyCode keyCode)
		{
			return false;
		}

		public static bool DefaultGetAnyKeyDown()
		{
			return false;
		}

		public static bool DefaultGetButtonDown(string buttonName)
		{
			return false;
		}

		public static bool DefaultGetButtonUp(string buttonName)
		{
			return false;
		}

		public static float DefaultGetAxis(string axisName)
		{
			return 0f;
		}

		public static Vector3 DefaultGetMousePosition()
		{
			return default(Vector3);
		}

		public static bool DefaultGetMouseButtonDown(int buttonNumber)
		{
			return false;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.Demo
{
	[AddComponentMenu(null)]
	[RequireComponent(typeof(CharacterController))]
	public class SimpleController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTempFreeze_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleController _003C_003E4__this;

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
			public _003CTempFreeze_003Ed__58(int _003C_003E1__state)
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
		private sealed class _003CQuitGame_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleController _003C_003E4__this;

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
			public _003CQuitGame_003Ed__62(int _003C_003E1__state)
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

		public string CurrentLocale;

		public bool DebugMode;

		public int playerId;

		private Player player;

		private CharacterController cc;

		public bool CanMove;

		public bool hasKeyboard;

		public Animator Melodii;

		public bool moving;

		public bool strafe;

		public GameObject PauseMenu;

		public bool gamePaused;

		public GameObject StickerBook;

		public Vector3 NextLocation;

		public GameObject DSeventSys;

		[Tooltip("Float parameter defined in animator controller that controls forward/backward speed.")]
		[Header("Animator")]
		public string forwardSpeedFloatParameter;

		[Tooltip("Float parameter defined in animator controller that controls left/right side-step speed.")]
		public string lateralSpeedFloatParameter;

		[Tooltip("Bool parameter defined in animator controller that specifies whether to use two-hand weapon animation or one-hand.")]
		public string twoHandWeaponBoolParameter;

		[Tooltip("Trigger parameter defined in animator controller that makes the animator play an attack animation.")]
		public string attackTriggerParameter;

		[Tooltip("Speed at which player moves if animator doesn't use root motion.")]
		[Header("Movement & Camera")]
		public float runSpeed;

		public float runSpeedOG;

		public float dashSpeed;

		public float dashSpeedOG;

		public float maxSpeed;

		public float acceleration;

		[Tooltip("Mouse look rotation sensitivity.")]
		public float mouseSensitivityX;

		public float mouseSensitivityY;

		[Tooltip("Maximum up/down angles for mouse look.")]
		public float mouseMinimumY;

		public float mouseMaximumY;

		[Tooltip("Use two-hand weapon animation.")]
		[Header("Attack")]
		public bool useTwoHandWeapon;

		[Tooltip("Attack animation checks for target hit at this time in animation.")]
		public float hitDelay;

		[Tooltip("Play this sound at Hit Delay time.")]
		public AudioClip attackSound;

		[Tooltip("Distance at which attack can hit target.")]
		public float hitDistance;

		[Tooltip("Check for targets on these layers.")]
		public LayerMask hitLayerMask;

		[Tooltip("Send this message to targets that are hit.")]
		public string damageMessage;

		[Tooltip("Send with parameter with the Damage Message.")]
		public float weaponDamage;

		[Header("Input")]
		public string horizontalAxis;

		public string verticalAxis;

		public string mouseXAxis;

		public string mouseYAxis;

		public string attackButton;

		private CharacterController m_controller;

		private SmoothCameraWithBumper m_smoothCamera;

		private Animator m_animator;

		private float m_cameraRotationY;

		private Quaternion m_originalCameraRotation;

		private bool m_firing;

		private float accel;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnFired()
		{
		}

		private void SetSpeed(float forwardSpeed, float lateralSpeed)
		{
		}

		private void OnConversationStart(Transform actor)
		{
		}

		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		public void StopMoving()
		{
		}

		public void OkUreFree()
		{
		}

		public void StopMovingTemp()
		{
		}

		[IteratorStateMachine(typeof(_003CTempFreeze_003Ed__58))]
		private IEnumerator TempFreeze()
		{
			return null;
		}

		public void Resume()
		{
		}

		public void ResumeToStickerBook()
		{
		}

		public void Quit()
		{
		}

		[IteratorStateMachine(typeof(_003CQuitGame_003Ed__62))]
		private IEnumerator QuitGame()
		{
			return null;
		}

		public void OpenStickerBook()
		{
		}

		public void GetKB()
		{
		}

		public void ResetGame()
		{
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class UIPanel : MonoBehaviour
	{
		public enum StartState
		{
			GameObjectState = 0,
			Open = 1,
			Closed = 2
		}

		public enum PanelState
		{
			Uninitialized = 0,
			Opening = 1,
			Open = 2,
			Closing = 3,
			Closed = 4
		}

		[CompilerGenerated]
		private sealed class _003CRefreshAfterOneFrameCoroutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIPanel _003C_003E4__this;

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
			public _003CRefreshAfterOneFrameCoroutine_003Ed__46(int _003C_003E1__state)
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

		[Tooltip("When enabling the panel, select this if input device is Joystick or Keyboard.")]
		public GameObject firstSelected;

		[Tooltip("If non-zero, seconds between checks to ensure that one of the panel's Selectables is focused when this panel is active and on top.")]
		public float focusCheckFrequency;

		[Tooltip("If non-zero, refresh list of Selectables at this frequency when this panel is active and on top. Use if Selectables are added dynamically.")]
		public float refreshSelectablesFrequency;

		[Tooltip("Reselect previous selectable when disabling this panel.")]
		public bool selectPreviousOnDisable;

		[Tooltip("When opening, set this animator trigger.")]
		public string showAnimationTrigger;

		[Tooltip("When closing, set this animator trigger.")]
		public string hideAnimationTrigger;

		[Tooltip("Normally the panel considers itself open at start if the GameObject starts active (GameObjectState). To explicitly specify whether the panel should start open or closed, select Open or Closed from the dropdown.")]
		public StartState startState;

		[Tooltip("Do not set panel state to Open until Show animation has finished.")]
		public bool waitForShowAnimationToSetOpen;

		[SerializeField]
		[Tooltip("Deactivate panel GameObject when panel is closed.")]
		protected bool m_deactivateOnHidden;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public UnityEvent onClosed;

		public UnityEvent onBackButtonDown;

		protected GameObject m_previousSelected;

		protected GameObject m_lastSelected;

		protected List<GameObject> selectables;

		private float m_timeNextCheck;

		private float m_timeNextRefresh;

		private int m_frameLastOpened;

		public static bool monitorSelection;

		protected static List<UIPanel> panelStack;

		private PanelState m_panelState;

		private UIAnimatorMonitor m_animatorMonitor;

		private Animator m_animator;

		public bool deactivateOnHidden
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected static UIPanel topPanel => null;

		public PanelState panelState
		{
			get
			{
				return default(PanelState);
			}
			set
			{
			}
		}

		public virtual bool waitForShowAnimation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isOpen => false;

		public UIAnimatorMonitor animatorMonitor => null;

		private Animator myAnimator => null;

		protected virtual void Start()
		{
		}

		public void RefreshSelectablesList()
		{
		}

		public void RefreshAfterOneFrame()
		{
		}

		[IteratorStateMachine(typeof(_003CRefreshAfterOneFrameCoroutine_003Ed__46))]
		private IEnumerator RefreshAfterOneFrameCoroutine()
		{
			return null;
		}

		protected void PushToPanelStack()
		{
		}

		protected void PopFromPanelStack()
		{
		}

		public void TakeFocus()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		public virtual void SetOpen(bool value)
		{
		}

		public virtual void Toggle()
		{
		}

		protected virtual void OnVisible()
		{
		}

		protected virtual void OnHidden()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void SetFocus(GameObject selectable)
		{
		}

		public virtual void CheckFocus()
		{
		}

		protected GameObject GetFirstInteractableButton()
		{
			return null;
		}
	}
}

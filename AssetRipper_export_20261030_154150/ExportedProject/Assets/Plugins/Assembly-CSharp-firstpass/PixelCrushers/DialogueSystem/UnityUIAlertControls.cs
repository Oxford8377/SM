using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIAlertControls : AbstractUIAlertControls
	{
		[Tooltip("Optional panel containing the alert line; can contain other doodads and effects, too")]
		public Graphic panel;

		[Tooltip("Shows the alert message text")]
		public Text line;

		[Tooltip("Optional continue button; configure OnClick to invoke dialogue UI's OnContinue method")]
		public Button continueButton;

		[Tooltip("Wait for previous alerts to finish before showing new alert; if unticked, new alerts replace old")]
		public bool queueAlerts;

		[Tooltip("Wait for the previous alert's Hide animation to finish before showing the next queued alert")]
		public bool waitForHideAnimation;

		[Tooltip("Optional animation transitions; panel should have an Animator")]
		public UIAnimationTransitions animationTransitions;

		private UIShowHideController m_showHideController;

		public override bool isVisible => false;

		public bool IsHiding => false;

		private UIShowHideController showHideController => null;

		public override void SetActive(bool value)
		{
		}

		private void ShowPanel()
		{
		}

		private void HidePanel()
		{
		}

		public void ActivateUIElements()
		{
		}

		public void DeactivateUIElements()
		{
		}

		public override void SetMessage(string message, float duration)
		{
		}

		public void AutoFocus(bool allowStealFocus = true)
		{
		}
	}
}

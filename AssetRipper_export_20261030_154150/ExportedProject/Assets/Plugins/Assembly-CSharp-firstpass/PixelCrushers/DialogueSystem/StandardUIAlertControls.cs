using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIAlertControls : AbstractUIAlertControls
	{
		[Tooltip("Main alert panel (optional).")]
		public UIPanel panel;

		[Tooltip("Alert text.")]
		public UITextField alertText;

		[Tooltip("Wait for previous alerts to finish before showing new alert; if unticked, new alerts replace old.")]
		public bool queueAlerts;

		[Tooltip("If a message is already queued to display, don't queue another.")]
		public bool dontQueueDuplicates;

		[Tooltip("Wait for the previous alert's Hide animation to finish before showing the next queued alert.")]
		public bool waitForHideAnimation;

		[Tooltip("If message contains [f], show immediately instead of queueing.")]
		public bool allowForceImmediate;

		private bool m_initializedAnimator;

		public override bool isVisible => false;

		public bool isHiding => false;

		public override void SetActive(bool value)
		{
		}

		public void HideImmediate()
		{
		}

		public override void SetMessage(string message, float duration)
		{
		}
	}
}

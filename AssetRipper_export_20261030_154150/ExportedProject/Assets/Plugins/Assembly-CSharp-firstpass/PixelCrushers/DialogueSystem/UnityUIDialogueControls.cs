using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIDialogueControls : AbstractDialogueUIControls
	{
		[Tooltip("Panel containing the entire conversation UI")]
		public Graphic panel;

		[Tooltip("Optional animation transitions; panel should have an Animator")]
		public UIAnimationTransitions animationTransitions;

		public UnityUISubtitleControls npcSubtitle;

		public UnityUISubtitleControls pcSubtitle;

		public UnityUIResponseMenuControls responseMenu;

		private UIShowHideController m_showHideController;

		public override AbstractUISubtitleControls npcSubtitleControls => null;

		public override AbstractUISubtitleControls pcSubtitleControls => null;

		public override AbstractUIResponseMenuControls responseMenuControls => null;

		private UIShowHideController showHideController => null;

		public override void SetActive(bool value)
		{
		}

		public override void ShowPanel()
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
	}
}

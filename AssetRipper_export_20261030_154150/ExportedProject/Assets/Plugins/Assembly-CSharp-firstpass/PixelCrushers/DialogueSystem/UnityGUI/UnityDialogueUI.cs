using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[AddComponentMenu(null)]
	public class UnityDialogueUI : AbstractDialogueUI
	{
		public GUIRoot guiRoot;

		public UnityDialogueControls dialogue;

		public GUIControl[] qteIndicators;

		public UnityAlertControls alert;

		private UnityUIRoot unityUIRoot;

		private UnityQTEControls unityQTEControls;

		public override AbstractUIRoot uiRootControls => null;

		public override AbstractDialogueUIControls dialogueControls => null;

		public override AbstractUIQTEControls qteControls => null;

		public override AbstractUIAlertControls alertControls => null;

		public override void Awake()
		{
		}

		public override void Open()
		{
		}

		private void FindControls()
		{
		}

		private void SetupContinueButton(GUIButton continueButton)
		{
		}
	}
}

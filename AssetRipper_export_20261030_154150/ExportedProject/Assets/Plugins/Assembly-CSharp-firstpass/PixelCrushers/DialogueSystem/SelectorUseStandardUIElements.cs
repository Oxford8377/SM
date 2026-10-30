using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class SelectorUseStandardUIElements : MonoBehaviour
	{
		[Serializable]
		public class TagInfo
		{
			[Tooltip("Use the UI elements below for usables with this tag. Tags take precedence over layers.")]
			public string tag;

			public string defaultUseMessage;

			public StandardUISelectorElements UIElements;
		}

		[Serializable]
		public class LayerInfo
		{
			[Tooltip("Use the UI elements below for usables in these layers.")]
			public LayerMask layerMask;

			public string defaultUseMessage;

			public StandardUISelectorElements UIElements;
		}

		public List<TagInfo> tagSpecificElements;

		public List<LayerInfo> layerSpecificElements;

		private Selector selector;

		private ProximitySelector proximitySelector;

		private string defaultUseMessage;

		private Usable usable;

		private bool lastInRange;

		private AbstractUsableUI usableUI;

		private bool started;

		private string originalDefaultUseMessage;

		private bool previousUseDefaultGUI;

		private StandardUISelectorElements m_elements;

		protected float CurrentDistance => 0f;

		public StandardUISelectorElements elements
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ConnectDelegates()
		{
		}

		public void DisconnectDelegates()
		{
		}

		private void SetElementsForUsable(Usable usable)
		{
		}

		private void OnSelectedUsable(Usable usable)
		{
		}

		private void OnDeselectedUsable(Usable usable)
		{
		}

		private string GetUseMessage()
		{
			return null;
		}

		private void ShowControls()
		{
		}

		private void HideControls()
		{
		}

		private void DeactivateControls()
		{
		}

		private bool IsUsableInRange()
		{
			return false;
		}

		public void Update()
		{
		}

		protected void OnSelectorEnabled()
		{
		}

		protected void OnSelectorDisabled()
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		protected void ShowControlsOrUsableUI()
		{
		}

		private void UpdateDisplay(bool inRange)
		{
		}

		private void UpdateText(bool inRange)
		{
		}

		private void UpdateReticle(bool inRange)
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}

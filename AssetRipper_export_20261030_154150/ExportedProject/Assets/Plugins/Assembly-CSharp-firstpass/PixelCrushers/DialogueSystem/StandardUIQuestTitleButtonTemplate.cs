using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIQuestTitleButtonTemplate : StandardUIContentTemplate
	{
		[Tooltip("Button UI element.")]
		[Header("Quest Title Button")]
		public Button button;

		[Tooltip("Label text to set on button.")]
		public UITextField label;

		[Header("Tracking Toggle")]
		public StandardUIToggleTemplate trackToggleTemplate;

		public virtual void Awake()
		{
		}

		public virtual void Assign(string questName, string displayName, ToggleChangedDelegate trackToggleDelegate)
		{
		}
	}
}

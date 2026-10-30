using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIButtonTemplate : StandardUIContentTemplate
	{
		[Tooltip("Button UI element.")]
		public Button button;

		public UITextField label;

		private void Awake()
		{
		}

		public void Assign(string labelText)
		{
		}
	}
}

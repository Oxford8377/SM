using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIColorText : MonoBehaviour
	{
		public Color color;

		public UITextField text;

		private Color originalColor;

		private void Awake()
		{
		}

		public void ApplyColor()
		{
		}

		public void UndoColor()
		{
		}
	}
}

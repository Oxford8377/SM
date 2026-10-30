using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class UITextColor : MonoBehaviour
	{
		public Color color;

		public Text text;

		private Color m_originalColor;

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

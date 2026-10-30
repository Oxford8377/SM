using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUIResponseButton : MonoBehaviour
	{
		public Button button;

		public Text label;

		[Tooltip("Set the button's text to this color by default")]
		public Color defaultColor;

		[Tooltip("Apply emphasis tag colors to the button background")]
		public bool setButtonColor;

		[Tooltip("Apply emphasis tag colors to the button text")]
		public bool setLabelColor;

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool clickable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool visible { get; set; }

		public Response response { get; set; }

		public Transform target { get; set; }

		public void Reset()
		{
		}

		public void Awake()
		{
		}

		public void SetFormattedText(FormattedText formattedText)
		{
		}

		public void SetUnformattedText(string unformattedText)
		{
		}

		protected virtual void SetColor(Color currentColor)
		{
		}

		public void OnClick()
		{
		}
	}
}

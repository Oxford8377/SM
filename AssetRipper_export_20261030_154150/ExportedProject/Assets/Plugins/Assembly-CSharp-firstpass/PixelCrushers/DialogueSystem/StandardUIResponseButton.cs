using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIResponseButton : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		[HelpBox("If Button's OnClick() event is empty, this Standard UI Response Button component will automatically assign its OnClick method at runtime. If Button's OnClick() event has other elements, you *must* manually assign the StandardUIResponseButton.OnClick method to it.", HelpBoxMessageType.Info)]
		public Button button;

		[Tooltip("Text element to display response text.")]
		public UITextField label;

		[Tooltip("Apply emphasis tag colors to button text.")]
		public bool setLabelColor;

		[Tooltip("Set button's text to this color by default.")]
		public Color defaultColor;

		public virtual string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool isClickable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool isVisible { get; set; }

		public virtual Response response { get; set; }

		public virtual Transform target { get; set; }

		public virtual void Reset()
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void SetFormattedText(FormattedText formattedText)
		{
		}

		public virtual void SetUnformattedText(string unformattedText)
		{
		}

		protected virtual void SetColor(Color currentColor)
		{
		}

		public virtual void OnClick()
		{
		}

		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		protected virtual void SetCurrentResponse()
		{
		}
	}
}

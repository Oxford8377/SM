using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUITextTemplate : StandardUIContentTemplate
	{
		[Tooltip("Text UI element.")]
		[SerializeField]
		private UITextField m_text;

		public UITextField text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public void Assign(string text)
		{
		}
	}
}

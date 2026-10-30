using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIInputField : UIPanel, ITextFieldUI
	{
		[Tooltip("(Optional) Text field panel.")]
		public Graphic panel;

		[Tooltip("(Optional) Text element for prompt.")]
		public UITextField label;

		[Tooltip("Input field.")]
		public UIInputField inputField;

		[Tooltip("(Optional) Key code that accepts user's text input.")]
		public KeyCode acceptKey;

		[Tooltip("(Optional) Input button that accepts user's text input.")]
		public string acceptButton;

		[Tooltip("(Optional) Key code that cancels user's text input.")]
		public KeyCode cancelKey;

		[Tooltip("(Optional) Input button that cancels user's text input.")]
		public string cancelButton;

		[Tooltip("Automatically open touchscreen keyboard.")]
		public bool showTouchScreenKeyboard;

		[Tooltip("Allow blank text input.")]
		public bool allowBlankInput;

		public UnityEvent onAccept;

		public UnityEvent onCancel;

		protected AcceptedTextDelegate m_acceptedText;

		protected bool m_isAwaitingInput;

		protected TouchScreenKeyboard m_touchScreenKeyboard;

		protected bool m_isQuitting;

		protected virtual void OnApplicationQuit()
		{
		}

		protected override void Start()
		{
		}

		public virtual void StartTextInput(string labelText, string text, int maxLength, AcceptedTextDelegate acceptedText)
		{
		}

		protected override void Update()
		{
		}

		public virtual void CancelTextInput()
		{
		}

		public virtual void AcceptTextInput()
		{
		}

		protected virtual void Show()
		{
		}

		protected virtual void ShowTouchScreenKeyboard()
		{
		}

		protected virtual void Hide()
		{
		}

		protected virtual void SetActive(bool value)
		{
		}
	}
}

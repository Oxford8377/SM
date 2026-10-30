using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUITextFieldUI : MonoBehaviour, ITextFieldUI
	{
		[Tooltip("Optional panel containing the UI elements")]
		public Graphic panel;

		[Tooltip("Optional text element for prompt")]
		public Text label;

		public InputField textField;

		[Tooltip("Optional key code that accepts the input")]
		public KeyCode acceptKey;

		[Tooltip("Optional key code that cancels the input")]
		public KeyCode cancelKey;

		[Tooltip("Automatically open touchscreen keyboard")]
		public bool showTouchScreenKeyboard;

		public UnityEvent onAccept;

		public UnityEvent onCancel;

		private AcceptedTextDelegate acceptedText;

		private bool isAwaitingInput;

		private TouchScreenKeyboard touchScreenKeyboard;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void StartTextInput(string labelText, string text, int maxLength, AcceptedTextDelegate acceptedText)
		{
		}

		public void Update()
		{
		}

		public void CancelTextInput()
		{
		}

		public void AcceptTextInput()
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void SetActive(bool value)
		{
		}
	}
}

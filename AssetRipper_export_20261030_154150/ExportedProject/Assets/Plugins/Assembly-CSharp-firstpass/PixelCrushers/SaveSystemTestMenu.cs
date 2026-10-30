using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SaveSystemTestMenu : MonoBehaviour
	{
		[Tooltip("Unity input button that toggles menu open/closed.")]
		public string menuInputButton;

		[Tooltip("Optional GUI Skin to provide custom Label, Button, and Box styles.")]
		public GUISkin guiSkin;

		[Tooltip("Size of menu buttons.")]
		public Vector2 buttonSize;

		[Tooltip("Slot that menu saves game in.")]
		public int saveSlot;

		[Tooltip("Optional instructions to show when script starts.")]
		public string instructions;

		[Tooltip("How long to show instructions.")]
		public float instructionsDuration;

		[Tooltip("Pause the game while the menu is open.")]
		public bool pauseWhileOpen;

		[Tooltip("If Input Device Manager mode is mouse, show cursor when opening and hide when closing.")]
		public bool allowCursorWhileOpen;

		public UnityEvent onShow;

		public UnityEvent onHide;

		private bool m_isVisible;

		private float m_instructionsDoneTime;

		private bool m_prevCursorState;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void ToggleMenu()
		{
		}

		private void HandleCursor(bool open)
		{
		}

		private void OnGUI()
		{
		}
	}
}

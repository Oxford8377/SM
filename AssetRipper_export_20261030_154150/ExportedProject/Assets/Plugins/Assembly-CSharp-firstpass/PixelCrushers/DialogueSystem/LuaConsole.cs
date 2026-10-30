using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class LuaConsole : MonoBehaviour
	{
		[Tooltip("Hold down this key and press Second Key to open console.")]
		public KeyCode firstKey;

		[Tooltip("Hold down First Key and press this key to open console.")]
		public KeyCode secondKey;

		[Tooltip("Console is visible.")]
		public bool visible;

		[Tooltip("Optional GUI Skin to style console window.")]
		public GUISkin guiSkin;

		[Tooltip("Minimum size of console window.")]
		public Vector2 minSize;

		[Tooltip("Max number of previous commands to remember.")]
		public int maxHistory;

		[Tooltip("While open, set Time.timeScale to 0.")]
		public bool pauseGameWhileOpen;

		protected List<string> m_history;

		protected int m_historyPosition;

		protected string m_input;

		protected string m_output;

		protected Rect m_windowRect;

		protected Rect m_closeButtonRect;

		protected Vector2 m_scrollPosition;

		protected bool m_isFirstKeyDown;

		protected virtual void Start()
		{
		}

		protected virtual void SetVisible(bool newValue)
		{
		}

		protected virtual void OnGUI()
		{
		}

		protected virtual void DrawConsole()
		{
		}

		protected Rect DefineWindowRect()
		{
			return default(Rect);
		}

		protected virtual void DrawConsoleWindow(int id)
		{
		}

		protected virtual bool IsKeyEvent(KeyCode keyCode)
		{
			return false;
		}

		protected virtual void RunLuaCommand()
		{
		}

		protected virtual string GetLuaResultString(Lua.Result result)
		{
			return null;
		}

		protected virtual string FormatTableResult(Lua.Result result)
		{
			return null;
		}

		protected virtual void UseHistory(int direction)
		{
		}
	}
}

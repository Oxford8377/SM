using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class QuestLogWindowHotkey : MonoBehaviour
	{
		[Tooltip("Toggle the quest log window when this key is pressed.")]
		public KeyCode key;

		[Tooltip("Toggle the quest log window when this input button is presed.")]
		public string buttonName;

		[Tooltip("(Optional) Use this quest log window. If unassigned, will automatically find quest log window in scene. If you assign a window, assign a scene instance, not an uninstantiated prefab.")]
		public QuestLogWindow questLogWindow;

		public QuestLogWindow runtimeQuestLogWindow => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}

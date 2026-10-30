using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class DialogueEntrySceneEvent
	{
		public string guid;

		public GameObjectUnityEvent onExecute;
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class QuestStateDispatcher : MonoBehaviour
	{
		private List<QuestStateListener> m_listeners;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void AddListener(QuestStateListener listener)
		{
		}

		public void RemoveListener(QuestStateListener listener)
		{
		}

		private void UpdateListeners()
		{
		}

		public void OnQuestStateChange(string questName)
		{
		}
	}
}

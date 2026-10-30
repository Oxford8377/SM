using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class QuestStateIndicator : MonoBehaviour
	{
		[Tooltip("GameObject such as a world space canvas element associated with each indicator level. A typical use is to associate indicator level 0 = nothing (unassigned), level 1 = question mark, and level 2 = exclamation mark.")]
		public GameObject[] indicators;

		private List<List<QuestStateListener>> m_currentIndicatorCount;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializeCurrentIndicatorCount()
		{
		}

		public void SetIndicatorLevel(QuestStateListener listener, int indicatorLevel)
		{
		}

		public void UpdateIndicator()
		{
		}
	}
}

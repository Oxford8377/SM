using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUIQuestTrackTemplate : MonoBehaviour
	{
		[Header("Quest Heading")]
		[Tooltip("The heading - name or description depends on tracker setting")]
		public Text description;

		public UnityUIQuestTemplateAlternateDescriptions alternateDescriptions;

		[Header("Quest Entries")]
		[Tooltip("(Optional) If set, holds instantiated quest entries")]
		public Transform entryContainer;

		[Tooltip("Used for quest entries")]
		public Text entryDescription;

		public UnityUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		private List<Text> instances;

		private int numEntries;

		public bool ArePropertiesAssigned => false;

		public void Initialize()
		{
		}

		public void SetDescription(string text, QuestState questState)
		{
		}

		private void SetFirstValidTextElement(string text, params Text[] textElements)
		{
		}

		public void AddEntryDescription(string text, QuestState entryState)
		{
		}

		private void InstantiateFirstValidTextElement(string text, Transform container, params Text[] textElements)
		{
		}
	}
}

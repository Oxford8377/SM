using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUIQuestTemplate : MonoBehaviour
	{
		[Header("Quest Heading")]
		[Tooltip("The heading - name or description depends on window setting")]
		public Button heading;

		[Tooltip("Used for Description")]
		public Text description;

		public UnityUIQuestTemplateAlternateDescriptions alternateDescriptions;

		[Tooltip("(Optional) If set, holds instantiated quest entries")]
		[Header("Quest Entries")]
		public Transform entryContainer;

		[Tooltip("Used for quest entries")]
		public Text entryDescription;

		public UnityUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		[Tooltip("Used for Track button if quest is trackable")]
		[Header("Buttons")]
		public Button trackButton;

		[Tooltip("Used for Abandon button if quest is abandonable")]
		public Button abandonButton;

		protected List<GameObject> entryInstances;

		protected int numEntries;

		public bool ArePropertiesAssigned => false;

		public virtual void Initialize()
		{
		}

		public virtual void ClearQuestDetails()
		{
		}

		public virtual void AddEntryDescription(string text, QuestState entryState)
		{
		}

		protected void InstantiateFirstValidTextElement(string text, Transform container, params Text[] textElements)
		{
		}
	}
}

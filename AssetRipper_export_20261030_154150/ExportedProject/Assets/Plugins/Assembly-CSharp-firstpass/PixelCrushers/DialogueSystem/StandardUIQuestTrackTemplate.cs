using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIQuestTrackTemplate : MonoBehaviour
	{
		[Tooltip("The heading - name or description depends on tracker setting")]
		[Header("Quest Heading")]
		public UITextField description;

		public StandardUIQuestTemplateAlternateDescriptions alternateDescriptions;

		[Tooltip("(Optional) If set, holds instantiated quest entries")]
		[Header("Quest Entries")]
		public Transform entryContainer;

		[Tooltip("Used for quest entries")]
		public UITextField entryDescription;

		public StandardUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		protected List<GameObject> m_instances;

		protected int numEntries;

		public bool arePropertiesAssigned => false;

		public virtual void Initialize()
		{
		}

		public virtual void SetDescription(string text, QuestState questState)
		{
		}

		public virtual void AddEntryDescription(string text, QuestState entryState)
		{
		}

		protected void SetFirstValidTextElement(string text, params UITextField[] textElements)
		{
		}

		protected void InstantiateFirstValidTextElement(string text, Transform container, params UITextField[] textElements)
		{
		}
	}
}

using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandQTE : SequencerCommand
	{
		private int index;

		private float stopTime;

		private string button;

		private string variableName;

		private string variableQTEValue;

		private FieldType variableType;

		public void Start()
		{
		}

		private FieldType GetVariableType()
		{
			return default(FieldType);
		}

		public void Update()
		{
		}

		private string ValueAsString(FieldType fieldType, string fieldValue)
		{
			return null;
		}

		public void OnDestroy()
		{
		}
	}
}

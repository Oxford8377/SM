using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/UI Message Setter")]
	public class UIMessageSetter : MonoBehaviour
	{
		[EventID]
		public string eventID;

		public GUIStyle style;

		private KoreographyEvent curTextEvent;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGUI()
		{
		}

		private void UpdateText(KoreographyEvent evt, int sampleTime, int sampleDelta, DeltaSlice deltaSlice)
		{
		}
	}
}

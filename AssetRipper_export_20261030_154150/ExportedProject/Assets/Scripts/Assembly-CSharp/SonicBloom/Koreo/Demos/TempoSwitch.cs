using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Tempo Switch")]
	public class TempoSwitch : MonoBehaviour
	{
		public Behaviour[] quarterNoteGroup;

		public Behaviour[] eighthNoteGroup;

		private int lastQuarterNote;

		private int lastEighthNote;

		private void Update()
		{
		}

		private void SwitchGroup(Behaviour[] behaviours, bool bGroupOn)
		{
		}
	}
}

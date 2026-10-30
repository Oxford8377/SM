using UnityEngine;
using UnityEngine.UI;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Demo Delay Display UI")]
	public class DemoDelayDisplayUI : MonoBehaviour
	{
		[Tooltip("The Text Component that will display the Event Delay number.")]
		public Text readoutText;

		[Tooltip("The Slider that controls the Event Delay number.")]
		public Slider slider;

		private void Start()
		{
		}

		public void SetNewDelay(float newDelay)
		{
		}
	}
}

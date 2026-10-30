using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Cube Scaler")]
	public class CubeScaler : MonoBehaviour
	{
		[EventID]
		public string eventID;

		public float minScale;

		public float maxScale;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void AdjustScale(KoreographyEvent evt, int sampleTime, int sampleDelta, DeltaSlice deltaSlice)
		{
		}
	}
}

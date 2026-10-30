using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[RequireComponent(typeof(ParticleSystem))]
	[AddComponentMenu("Koreographer/Demos/Emit Particles On Span")]
	public class EmitParticlesOnSpan : MonoBehaviour
	{
		[EventID]
		public string eventID;

		public float particlesPerBeat;

		private ParticleSystem particleCom;

		private int lastEmitFrame;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnParticleControlEvent(KoreographyEvent evt)
		{
		}
	}
}

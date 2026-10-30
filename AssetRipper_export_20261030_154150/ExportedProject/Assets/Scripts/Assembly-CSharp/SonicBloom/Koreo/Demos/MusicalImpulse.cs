using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[RequireComponent(typeof(Rigidbody))]
	[AddComponentMenu("Koreographer/Demos/Musical Impulse")]
	public class MusicalImpulse : MonoBehaviour
	{
		[EventID]
		public string eventID;

		public float jumpSpeed;

		private Rigidbody rigidbodyCom;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void AddImpulse(KoreographyEvent evt)
		{
		}
	}
}

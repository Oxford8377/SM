using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Note Object")]
	public class NoteObject : MonoBehaviour
	{
		[Tooltip("The visual to use for this Note Object.")]
		public SpriteRenderer visuals;

		private KoreographyEvent trackedEvent;

		private LaneController laneController;

		private RhythmGameController gameController;

		private static Vector3 Lerp(Vector3 from, Vector3 to, float t)
		{
			return default(Vector3);
		}

		public void Initialize(KoreographyEvent evt, Color color, LaneController laneCont, RhythmGameController gameCont)
		{
		}

		private void Reset()
		{
		}

		private void Update()
		{
		}

		private void UpdateHeight()
		{
		}

		private void UpdatePosition()
		{
		}

		public bool IsNoteHittable()
		{
			return false;
		}

		public bool IsNoteMissed()
		{
			return false;
		}

		private void ReturnToPool()
		{
		}

		public void OnHit()
		{
		}

		public void OnClear()
		{
		}
	}
}

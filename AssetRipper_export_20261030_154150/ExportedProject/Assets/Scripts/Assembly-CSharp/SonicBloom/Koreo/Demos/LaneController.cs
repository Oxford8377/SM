using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Lane Controller")]
	public class LaneController : MonoBehaviour
	{
		[Tooltip("The Color of Note Objects and Buttons in this Lane.")]
		public Color color;

		[Tooltip("A reference to the visuals for the \"target\" location.")]
		public SpriteRenderer targetVisuals;

		[Tooltip("The Keyboard Button used by this lane.")]
		public KeyCode keyboardButton;

		[Tooltip("A list of Payload strings that Koreography Events will contain for this Lane.")]
		public List<string> matchedPayloads;

		private List<KoreographyEvent> laneEvents;

		private Queue<NoteObject> trackedNotes;

		private RhythmGameController gameController;

		private float spawnY;

		private float despawnY;

		private int pendingEventIdx;

		private Vector3 defaultScale;

		private float scaleNormal;

		private float scalePress;

		private float scaleHold;

		public Vector3 SpawnPosition => default(Vector3);

		public Vector3 TargetPosition => default(Vector3);

		public float DespawnY => 0f;

		public void Initialize(RhythmGameController controller)
		{
		}

		public void Restart(int newSampleTime = 0)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void AdjustScale(float multiplier)
		{
		}

		private int GetSpawnSampleOffset()
		{
			return 0;
		}

		public void CheckNoteHit()
		{
		}

		private void CheckSpawnNext()
		{
		}

		public void AddEventToLane(KoreographyEvent evt)
		{
		}

		public bool DoesMatchPayload(string payload)
		{
			return false;
		}

		public void SetScaleDefault()
		{
		}

		public void SetScalePress()
		{
		}

		public void SetScaleHold()
		{
		}
	}
}

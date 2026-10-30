using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Rhythm Game Controller")]
	public class RhythmGameController : MonoBehaviour
	{
		[EventID]
		[Tooltip("The Event ID of the track to use for target generation.")]
		public string eventID;

		[Tooltip("The number of milliseconds (both early and late) within which input will be detected as a Hit.")]
		[Range(8f, 150f)]
		public float hitWindowRangeInMS;

		[Tooltip("The number of units traversed per second by Note Objects.")]
		public float noteSpeed;

		[Tooltip("The archetype (blueprints) to use for generating notes.  Can be a prefab.")]
		public NoteObject noteObjectArchetype;

		[Tooltip("The list of Lane Controller objects that represent a lane for an event to travel down.")]
		public List<LaneController> noteLanes;

		[Tooltip("The amount of time in seconds to provide before playback of the audio begins.  Changes to this value are not immediately handled during the lead-in phase while playing in the Editor.")]
		public float leadInTime;

		[Tooltip("The Audio Source through which the Koreographed audio will be played.  Be sure to disable 'Auto Play On Awake' in the Music Player.")]
		public AudioSource audioCom;

		private float leadInTimeLeft;

		private float timeLeftToPlay;

		private Koreography playingKoreo;

		private int hitWindowRangeInSamples;

		private Stack<NoteObject> noteObjectPool;

		public int HitWindowSampleWidth => 0;

		public float WindowSizeInUnits => 0f;

		public int SampleRate => 0;

		public int DelayedSampleTime => 0;

		private void Start()
		{
		}

		private void InitializeLeadIn()
		{
		}

		private void Update()
		{
		}

		private void UpdateInternalValues()
		{
		}

		public NoteObject GetFreshNoteObject()
		{
			return null;
		}

		public void ReturnNoteObjectToPool(NoteObject obj)
		{
		}

		public void Restart()
		{
		}
	}
}

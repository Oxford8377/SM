using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[TrackColor(0.855f, 0.8623f, 0.87f)]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(PlaySequenceClip))]
	public class PlaySequenceTrack : TrackAsset
	{
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}
	}
}

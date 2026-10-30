using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[TrackClipType(typeof(BarkClip))]
	[TrackBindingType(typeof(GameObject))]
	[TrackColor(0.855f, 0.8623f, 0.87f)]
	public class BarkTrack : TrackAsset
	{
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}
	}
}

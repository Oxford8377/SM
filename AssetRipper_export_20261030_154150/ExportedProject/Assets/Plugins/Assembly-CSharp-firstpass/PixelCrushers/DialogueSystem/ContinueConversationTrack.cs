using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[TrackColor(0.855f, 0.8623f, 0.87f)]
	[TrackClipType(typeof(ContinueConversationClip))]
	[TrackBindingType(typeof(GameObject))]
	public class ContinueConversationTrack : TrackAsset
	{
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}
	}
}

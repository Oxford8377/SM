using Cinemachine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class CinemachineCameraPriorityOnDialogueEvent : ActOnDialogueEvent
	{
		[Tooltip("The Cinemachine virtual camera whose priority to control.")]
		public CinemachineVirtualCamera virtualCamera;

		[Tooltip("Set the virtual camera to this priority when the start event occurs.")]
		public int onStart;

		[Tooltip("Set the virtual camera to this priority when the end event occurs.")]
		public int onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}
	}
}

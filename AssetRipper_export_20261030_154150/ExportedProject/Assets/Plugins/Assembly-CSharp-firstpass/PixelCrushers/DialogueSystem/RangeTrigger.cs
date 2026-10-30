using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class RangeTrigger : MonoBehaviour
	{
		[Tooltip("These conditions must be true for the Range Trigger to affect GameObjects and components and invoke events")]
		public Condition condition;

		[Tooltip("Activate these GameObjects on trigger enter, deactivate them on trigger exit")]
		public GameObject[] gameObjects;

		[Tooltip("Enable these components on trigger enter, disable them on trigger exit")]
		public Component[] components;

		public UnityEvent onEnter;

		public UnityEvent onExit;

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		private void SetTargets(bool value)
		{
		}
	}
}

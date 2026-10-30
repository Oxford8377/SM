using MoreMountains.InventoryEngine;
using MoreMountains.Tools;
using UnityEngine;

namespace PixelCrushers.InventoryEngineSupport
{
	public class MessageOnInventoryEngineContentChange : MonoBehaviour, MMEventListener<MMInventoryEvent>, MMEventListenerBase
	{
		[Tooltip("Message to send.")]
		public StringField message;

		[Tooltip("Parameter to send. If blank, sends the name of this inventory.")]
		public StringField parameter;

		public string runtimeParameter => null;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnMMEvent(MMInventoryEvent eventType)
		{
		}
	}
}

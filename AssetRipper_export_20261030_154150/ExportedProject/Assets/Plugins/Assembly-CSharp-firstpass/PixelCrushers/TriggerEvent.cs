using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class TriggerEvent : TagMaskEvent
	{
		[SerializeField]
		private GameObjectUnityEvent m_onTriggerEnter;

		[SerializeField]
		private GameObjectUnityEvent m_onTriggerExit;

		public GameObjectUnityEvent onTriggerEnter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObjectUnityEvent onTriggerExit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void OnTriggerExit(Collider other)
		{
		}
	}
}

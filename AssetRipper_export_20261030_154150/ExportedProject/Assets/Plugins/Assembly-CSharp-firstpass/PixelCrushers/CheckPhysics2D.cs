using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class CheckPhysics2D : MonoBehaviour
	{
		public UnityEvent usePhysics2DDefined;

		public UnityEvent usePhysics2DUndefined;

		private void Start()
		{
		}
	}
}

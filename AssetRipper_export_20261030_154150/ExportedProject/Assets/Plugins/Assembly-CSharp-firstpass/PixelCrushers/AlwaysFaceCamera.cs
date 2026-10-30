using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class AlwaysFaceCamera : MonoBehaviour
	{
		[Tooltip("Leave Y rotation untouched.")]
		[SerializeField]
		private bool m_yAxisOnly;

		[SerializeField]
		[Tooltip("Flip 180 degrees.")]
		private bool m_rotate180;

		private Camera m_mainCamera;

		public bool yAxisOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool rotate180
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Update()
		{
		}
	}
}

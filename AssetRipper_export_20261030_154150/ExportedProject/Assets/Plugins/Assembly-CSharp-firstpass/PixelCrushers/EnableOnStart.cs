using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class EnableOnStart : MonoBehaviour
	{
		[Tooltip("Enable this component when on start.")]
		[SerializeField]
		private Component m_component;

		public Component component
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}
	}
}

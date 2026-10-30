using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class InstantiatePrefabs : MonoBehaviour
	{
		public enum Position
		{
			ScreenSpaceUI = 0,
			OriginalPosition = 1,
			ParentPosition = 2
		}

		[Tooltip("Make instances children of this parent. If unassigned, use this GameObject.")]
		[SerializeField]
		private Transform m_parent;

		[Tooltip("Prefabs to instantiate.")]
		[SerializeField]
		private GameObject[] m_prefabs;

		[Tooltip("Untick for screen-space GameObjects such as UI elements; tick for world-space GameObjects.")]
		[SerializeField]
		private Position m_position;

		private void OnEnable()
		{
		}
	}
}

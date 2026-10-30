using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class ScenePortal : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Only objects with this tag can use the portal.")]
		private string m_requiredTag;

		[SerializeField]
		[Tooltip("Go to this scene.")]
		private string m_destinationSceneName;

		[Tooltip("If not blank, move the player to the GameObject with this name.")]
		[SerializeField]
		private string m_spawnpointNameInDestinationScene;

		[SerializeField]
		private UnityEvent m_onUsePortal;

		private bool m_isLoadingScene;

		public string requiredTag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string destinationSceneName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string spawnpointNameInDestinationScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isLoadingScene
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public UnityEvent onUsePortal => null;

		public virtual void UsePortal()
		{
		}

		protected void LoadScene()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

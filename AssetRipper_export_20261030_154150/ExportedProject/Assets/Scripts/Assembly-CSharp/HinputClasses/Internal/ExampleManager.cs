using UnityEngine;

namespace HinputClasses.Internal
{
	public class ExampleManager : MonoBehaviour
	{
		[Header("STATE")]
		public GameObject currentPanel;

		[Header("REFERENCES")]
		public GameObject oneGamepad;

		public GameObject twoGamepads;

		public GameObject fourGamepads;

		public GameObject eightGamepads;

		public void Start()
		{
		}

		public void Update()
		{
		}

		private void ActivatePanel(GameObject panel)
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace HinputClasses.Internal
{
	public class ExampleGamepad : MonoBehaviour
	{
		[Header("OPTIONS")]
		public int index;

		public float stickDistance;

		[Header("STATE")]
		public Vector3 leftStickStartPosition;

		public Vector3 rightStickStartPosition;

		[Header("REFERENCES")]
		public GameObject leftStick;

		public GameObject rightStick;

		public GameObject connectedButton;

		public GameObject vibrate;

		public Text text;

		[Space]
		public GameObject AHighlight;

		public GameObject BHighlight;

		public GameObject XHighlight;

		public GameObject YHighlight;

		public GameObject leftTriggerHighlight;

		public GameObject rightTriggerHighlight;

		public GameObject leftBumperHighlight;

		public GameObject rightBumperHighlight;

		public GameObject backHighlight;

		public GameObject startHighlight;

		public GameObject dpadUpHighlight;

		public GameObject dpadDownHighlight;

		public GameObject dpadLeftHighlight;

		public GameObject dpadRightHighlight;

		public GameObject leftStickClickHighlight;

		public GameObject rightStickClickHighlight;

		private Gamepad gamepad => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void CheckSetup()
		{
		}

		private void UpdateVibrationButton()
		{
		}

		private void UpdateAllStickPositions()
		{
		}

		private void UpdateConnectedButton()
		{
		}

		private void UpdateAllButtonHighlights()
		{
		}

		private void UpdateButtonHighLight(Pressable button, GameObject go, string input)
		{
		}

		public void Vibrate()
		{
		}
	}
}

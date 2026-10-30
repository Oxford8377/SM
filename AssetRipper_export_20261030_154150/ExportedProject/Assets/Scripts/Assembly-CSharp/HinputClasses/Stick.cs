using HinputClasses.Internal;
using UnityEngine;

namespace HinputClasses
{
	public class Stick
	{
		public readonly int index;

		public readonly string name;

		public readonly Gamepad gamepad;

		private readonly Axis horizontalAxis;

		private readonly Axis verticalAxis;

		private Vector2 positionRaw;

		public readonly StickPressedZone inPressedZone;

		public readonly StickDirection up;

		public readonly StickDirection down;

		public readonly StickDirection left;

		public readonly StickDirection right;

		public readonly StickDirection upLeft;

		public readonly StickDirection downLeft;

		public readonly StickDirection upRight;

		public readonly StickDirection downRight;

		public bool isEnabled { get; private set; }

		public Vector2 position { get; private set; }

		public float horizontal => 0f;

		public float vertical => 0f;

		public float distance => 0f;

		public float angle => 0f;

		public Vector3 worldPositionCamera => default(Vector3);

		public Vector3 worldPositionFlat => default(Vector3);

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public void Reset()
		{
		}

		public static implicit operator Vector2(Stick stick)
		{
			return default(Vector2);
		}

		public static implicit operator bool(Stick stick)
		{
			return false;
		}

		public Stick(string stickName, Gamepad gamepad, int index, bool isEnabled)
		{
		}

		protected virtual Vector2 GetPosition()
		{
			return default(Vector2);
		}

		public void Update()
		{
		}
	}
}

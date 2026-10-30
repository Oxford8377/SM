namespace HinputClasses.Internal
{
	public class Axis
	{
		private enum AT
		{
			None = 0,
			Axis = 1,
			Buttons = 2
		}

		private readonly string axisFullName;

		private readonly string positiveButtonFullName;

		private readonly string negativeButtonFullName;

		private AT AxisType;

		public Axis(string axisFullName, string positiveButtonFullName, string negativeButtonFullName)
		{
		}

		public Axis(string axisFullName)
		{
		}

		public float GetPosition()
		{
			return 0f;
		}

		private float GetAxisValue()
		{
			return 0f;
		}

		private float GetButtonValue()
		{
			return 0f;
		}
	}
}

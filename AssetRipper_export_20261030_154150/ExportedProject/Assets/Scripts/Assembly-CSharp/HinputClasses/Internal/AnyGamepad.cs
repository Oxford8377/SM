using UnityEngine;

namespace HinputClasses.Internal
{
	public class AnyGamepad : Gamepad
	{
		public override string type => null;

		public override bool isConnected => false;

		public override float leftVibration => 0f;

		public override float rightVibration => 0f;

		protected override bool UpdateIsRequired()
		{
			return false;
		}

		public override void Vibrate()
		{
		}

		public override void Vibrate(float duration)
		{
		}

		public override void Vibrate(float leftIntensity, float rightIntensity)
		{
		}

		public override void Vibrate(float leftIntensity, float rightIntensity, float duration)
		{
		}

		public override void Vibrate(AnimationCurve curve)
		{
		}

		public override void Vibrate(AnimationCurve leftCurve, AnimationCurve rightCurve)
		{
		}

		public override void Vibrate(VibrationPreset vibrationPreset)
		{
		}

		public override void Vibrate(VibrationPreset vibrationPreset, float duration)
		{
		}

		public override void Vibrate(VibrationPreset vibrationPreset, float leftIntensity, float rightIntensity)
		{
		}

		public override void Vibrate(VibrationPreset vibrationPreset, float leftIntensity, float rightIntensity, float duration)
		{
		}

		public override void VibrateAdvanced(float leftIntensity, float rightIntensity)
		{
		}

		public override void StopVibration()
		{
		}

		public override void StopVibration(float duration)
		{
		}
	}
}

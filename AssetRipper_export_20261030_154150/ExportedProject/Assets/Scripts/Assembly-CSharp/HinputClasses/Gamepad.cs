using System.Collections.Generic;
using HinputClasses.Internal;
using UnityEngine;

namespace HinputClasses
{
	public class Gamepad
	{
		private bool enableWhenConnected;

		protected Vibration vibration;

		public int index { get; protected set; }

		public string name { get; protected set; }

		public virtual string type => null;

		public virtual bool isConnected => false;

		public bool isEnabled { get; protected set; }

		public Button A { get; protected set; }

		public Button B { get; protected set; }

		public Button X { get; protected set; }

		public Button Y { get; protected set; }

		public Button leftBumper { get; protected set; }

		public Button rightBumper { get; protected set; }

		public Button back { get; protected set; }

		public Button start { get; protected set; }

		public Button leftStickClick { get; protected set; }

		public Button rightStickClick { get; protected set; }

		public Trigger leftTrigger { get; private set; }

		public Trigger rightTrigger { get; private set; }

		public Stick leftStick { get; protected set; }

		public Stick rightStick { get; protected set; }

		public Stick dPad { get; protected set; }

		public Pressable anyInput { get; private set; }

		public List<Stick> sticks { get; private set; }

		public List<Pressable> buttons { get; private set; }

		public virtual float leftVibration => 0f;

		public virtual float rightVibration => 0f;

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		protected Gamepad()
		{
		}

		public Gamepad(int index)
		{
		}

		protected void SetUp()
		{
		}

		public void Update()
		{
		}

		protected virtual bool UpdateIsRequired()
		{
			return false;
		}

		public virtual void Vibrate()
		{
		}

		public virtual void Vibrate(float duration)
		{
		}

		public virtual void Vibrate(float leftIntensity, float rightIntensity)
		{
		}

		public virtual void Vibrate(float leftIntensity, float rightIntensity, float duration)
		{
		}

		public virtual void Vibrate(AnimationCurve curve)
		{
		}

		public virtual void Vibrate(AnimationCurve leftCurve, AnimationCurve rightCurve)
		{
		}

		public virtual void Vibrate(VibrationPreset vibrationPreset)
		{
		}

		public virtual void Vibrate(VibrationPreset vibrationPreset, float duration)
		{
		}

		public virtual void Vibrate(VibrationPreset vibrationPreset, float leftIntensity, float rightIntensity)
		{
		}

		public virtual void Vibrate(VibrationPreset vibrationPreset, float leftIntensity, float rightIntensity, float duration)
		{
		}

		public virtual void VibrateAdvanced(float leftIntensity, float rightIntensity)
		{
		}

		public virtual void StopVibration()
		{
		}

		public virtual void StopVibration(float duration)
		{
		}
	}
}

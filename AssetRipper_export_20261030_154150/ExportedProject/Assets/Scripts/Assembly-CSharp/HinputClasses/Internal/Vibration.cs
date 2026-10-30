using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XInputDotNetPure;

namespace HinputClasses.Internal
{
	public class Vibration
	{
		private struct PresetCurves
		{
			public readonly AnimationCurve leftCurve;

			public readonly AnimationCurve rightCurve;

			public PresetCurves(AnimationCurve left, AnimationCurve right)
			{
				leftCurve = null;
				rightCurve = null;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_Vibrate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Vibration _003C_003E4__this;

			public float right;

			public float left;

			public float duration;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_Vibrate_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_Vibrate_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve leftCurve;

			public AnimationCurve rightCurve;

			public Vibration _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private bool _003CleftCurveIsOver_003E5__3;

			private bool _003CrightCurveIsOver_003E5__4;

			private float _003CleftCurveDuration_003E5__5;

			private float _003CrightCurveDuration_003E5__6;

			private float _003CleftCurveValue_003E5__7;

			private float _003CrightCurveValue_003E5__8;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_Vibrate_003Ed__14(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_StopVibration_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Vibration _003C_003E4__this;

			public float duration;

			private float _003CoriginLeft_003E5__2;

			private float _003CoriginRight_003E5__3;

			private float _003CtimeLeft_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_StopVibration_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly PlayerIndex index;

		private readonly bool canVibrate;

		private float prevLeft;

		private float prevRight;

		public float currentLeft;

		public float currentRight;

		public Vibration(int index)
		{
		}

		public void Update()
		{
		}

		public void Vibrate(float left, float right, float duration)
		{
		}

		public void Vibrate(AnimationCurve leftCurve, AnimationCurve rightCurve)
		{
		}

		public void Vibrate(VibrationPreset vibrationPreset, float left, float right, float duration)
		{
		}

		public void VibrateAdvanced(float left, float right)
		{
		}

		public void StopVibration(float duration)
		{
		}

		[IteratorStateMachine(typeof(_003C_Vibrate_003Ed__13))]
		private IEnumerator _Vibrate(float left, float right, float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_Vibrate_003Ed__14))]
		private IEnumerator _Vibrate(AnimationCurve leftCurve, AnimationCurve rightCurve)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_StopVibration_003Ed__15))]
		private IEnumerator _StopVibration(float duration)
		{
			return null;
		}

		private PresetCurves GetCurves(VibrationPreset vibrationPreset, float left, float right, float duration)
		{
			return default(PresetCurves);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class LODManager : MonoBehaviour
	{
		[Serializable]
		public class LOD
		{
			[SerializeField]
			[Tooltip("The minimum distance for this LOD.")]
			private float m_minDistance;

			[SerializeField]
			[Tooltip("The max distance for this LOD.")]
			private float m_maxDistance;

			public float minDistance
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float maxDistance
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool Contains(float distance)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CMonitorLOD_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LODManager _003C_003E4__this;

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
			public _003CMonitorLOD_003Ed__18(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("The LODs (levels of detail).")]
		private LOD[] m_levels;

		[Tooltip("The frequency at which to check distance from the player and update the current LOD if necessary.")]
		[SerializeField]
		private float m_monitorFrequency;

		private int m_currentLevel;

		private WaitForSeconds m_currentWaitForSeconds;

		private float m_currentWaitForSecondsValue;

		public LOD[] levels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float monitorFrequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Transform player { get; set; }

		private void Start()
		{
		}

		public void FindPlayer()
		{
		}

		[IteratorStateMachine(typeof(_003CMonitorLOD_003Ed__18))]
		private IEnumerator MonitorLOD()
		{
			return null;
		}

		public void CheckLOD()
		{
		}

		public static List<string> ZonePluginActivator()
		{
			return null;
		}
	}
}

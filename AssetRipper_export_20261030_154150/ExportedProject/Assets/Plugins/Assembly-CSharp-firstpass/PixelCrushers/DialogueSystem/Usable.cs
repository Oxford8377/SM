using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class Usable : MonoBehaviour
	{
		[Serializable]
		public class UsableEvents
		{
			public UnityEvent onSelect;

			public UnityEvent onDeselect;

			public UnityEvent onUse;
		}

		public string overrideName;

		public string overrideUseMessage;

		public float maxUseDistance;

		public UsableEvents events;

		public event UsableDelegate disabled
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Start()
		{
		}

		public virtual string GetName()
		{
			return null;
		}

		public virtual void OnSelectUsable()
		{
		}

		public virtual void OnDeselectUsable()
		{
		}

		public virtual void OnUseUsable()
		{
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class RunLuaBehaviour : PlayableBehaviour
	{
		[TextArea(5, 5)]
		[Tooltip("Run this Lua code.")]
		public string luaCode;
	}
}

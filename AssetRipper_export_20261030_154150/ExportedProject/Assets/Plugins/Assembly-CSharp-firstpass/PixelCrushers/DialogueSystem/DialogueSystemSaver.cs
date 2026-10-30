using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class DialogueSystemSaver : Saver
	{
		[Serializable]
		public class RawData
		{
			public byte[] bytes;
		}

		[Tooltip("If data was restored immediately after loading a scene, don't apply it again after save system waits specified number of frames for other scripts to initialize.")]
		public bool skipApplyDataAfterFramesIfApplyImmediate;

		[Tooltip("Save using raw data dump. If your database is extremely large, this method is faster but generates larger saved game data. If you use this option, use BinaryDataSerializer instead of JsonDataSerializer or data will be ridiculously large.")]
		public bool saveRawData;

		private bool m_appliedImmediate;

		public override void Reset()
		{
		}

		public override void Start()
		{
		}

		public override void OnDestroy()
		{
		}

		private void OnLoadGameStarted()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyDataImmediate()
		{
		}

		public override void ApplyData(string data)
		{
		}

		public override void OnBeforeSceneChange()
		{
		}

		public override void OnRestartGame()
		{
		}
	}
}

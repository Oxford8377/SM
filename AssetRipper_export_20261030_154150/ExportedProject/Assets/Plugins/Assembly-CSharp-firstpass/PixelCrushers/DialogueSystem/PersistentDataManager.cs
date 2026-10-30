using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Language.Lua;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class PersistentDataManager
	{
		public enum RecordPersistentDataOn
		{
			AllGameObjects = 0,
			OnlyRegisteredGameObjects = 1,
			NoGameObjects = 2
		}

		public class AsyncSaveOperation
		{
			public bool isDone;

			public string content;
		}

		public class AsyncRawDataOperation
		{
			public bool isDone;

			public byte[] content;
		}

		[CompilerGenerated]
		private sealed class _003CGetSaveDataAsyncCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AsyncSaveOperation asyncOp;

			private StringBuilder _003Csb_003E5__2;

			private int _003Ccount_003E5__3;

			private HashSet<GameObject>.Enumerator _003C_003E7__wrap3;

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
			public _003CGetSaveDataAsyncCoroutine_003Ed__58(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAppendConversationDataAsync_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StringBuilder sb;

			private int _003Ccount_003E5__2;

			private LuaTable _003CconversationTable_003E5__3;

			private int _003Ci_003E5__4;

			private Dictionary<LuaValue, LuaValue>.Enumerator _003C_003E7__wrap4;

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
			public _003CAppendConversationDataAsync_003Ed__60(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetRawDataAsyncCoroutine_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AsyncRawDataOperation asyncOp;

			private int _003Ccount_003E5__2;

			private HashSet<GameObject>.Enumerator _003C_003E7__wrap2;

			private MemoryStream _003Cms_003E5__4;

			private BinaryWriter _003Cwriter_003E5__5;

			private LuaTable _003CconversationTable_003E5__6;

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
			public _003CGetRawDataAsyncCoroutine_003Ed__64(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPrepSimStatusForRawDataAsync_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LuaTable conversationTable;

			private Dictionary<int, DialogueEntry> _003CdialogueEntryCache_003E5__2;

			private StringBuilder _003Csb_003E5__3;

			private int _003CnumEntriesDone_003E5__4;

			private int _003Ci_003E5__5;

			private Dictionary<LuaValue, LuaValue>.Enumerator _003C_003E7__wrap5;

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
			public _003CPrepSimStatusForRawDataAsync_003Ed__73(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static bool includeActorData;

		public static bool includeAllItemData;

		public static bool includeLocationData;

		public static bool includeAllConversationFields;

		public static bool includeSimStatus;

		public static string saveConversationSimStatusWithField;

		public static string saveDialogueEntrySimStatusWithField;

		public static bool includeRelationshipAndStatusData;

		public static bool initializeNewVariables;

		public static bool initializeNewSimStatus;

		public static GetCustomSaveDataDelegate GetCustomSaveData;

		public static RecordPersistentDataOn recordPersistentDataOn;

		private static HashSet<GameObject> listeners;

		private static bool useConversationID;

		private static bool useEntryID;

		private static Dictionary<int, string> s_dialogueEntrySimStatusFieldLookupTable;

		public static int asyncGameObjectBatchSize;

		public static int asyncDialogueEntryBatchSize;

		public static void RegisterPersistentData(GameObject go)
		{
		}

		public static void UnregisterPersistentData(GameObject go)
		{
		}

		public static void Reset(DatabaseResetOptions databaseResetOptions)
		{
		}

		public static void Reset()
		{
		}

		public static void Record()
		{
		}

		public static void Apply()
		{
		}

		private static void SendPersistentDataMessage(string message)
		{
		}

		public static void LevelWillBeUnloaded()
		{
		}

		public static void ApplySaveData(string saveData, DatabaseResetOptions databaseResetOptions = DatabaseResetOptions.KeepAllLoaded)
		{
		}

		public static void ApplyLuaInternal(string saveData, bool allowExceptions = false)
		{
		}

		private static void EnsureConversationTablesExistForAllSimX(string saveData)
		{
		}

		private static void EnsureQuestsExist(string saveData)
		{
		}

		public static string GetSaveData()
		{
			return null;
		}

		public static void AppendDialogueSystemData(StringBuilder sb)
		{
		}

		public static void AppendVariableData(StringBuilder sb)
		{
		}

		public static void AppendItemData(StringBuilder sb)
		{
		}

		private static void AppendFields(StringBuilder sb, LuaTableWrapper fields)
		{
		}

		private static string GetFieldKeyString(string key)
		{
			return null;
		}

		private static bool IsValidVarName(string key)
		{
			return false;
		}

		private static string GetFieldValueString(object o)
		{
			return null;
		}

		public static void AppendLocationData(StringBuilder sb)
		{
		}

		public static void AppendActorData(StringBuilder sb)
		{
		}

		private static void AppendAssetFieldData(StringBuilder sb, LuaTableWrapper fields)
		{
		}

		public static void AppendRelationshipAndStatusTables(StringBuilder sb)
		{
		}

		public static void RefreshRelationshipAndStatusTablesFromLua()
		{
		}

		public static void AppendConversationData(StringBuilder sb)
		{
		}

		private static void AppendAllConversationFields(StringBuilder sb)
		{
		}

		private static void AppendSimStatus(StringBuilder sb)
		{
		}

		private static int AppendSimStatusForConversation(StringBuilder sb, LuaTable conversationTable, int conversationID, LuaTable fieldTable)
		{
			return 0;
		}

		private static void ExpandCompressedSimStatusData()
		{
		}

		private static bool ExpandSimStatusForConversation(StringBuilder sb, int conversationID, string conversationIDString, LuaTable fieldTable, LuaString luaStringSimX, Dictionary<int, DialogueEntry> dialogueEntryCache)
		{
			return false;
		}

		private static char SimStatusToChar(string simStatus)
		{
			return '\0';
		}

		private static string CharToSimStatus(char c)
		{
			return null;
		}

		public static void InitializeNewVariablesFromDatabase()
		{
		}

		public static void InitializeNewActorFieldsFromDatabase()
		{
		}

		public static void InitializeNewQuestEntriesFromDatabase()
		{
		}

		public static void InitializeNewSimStatusFromDatabase()
		{
		}

		public static AsyncSaveOperation GetSaveDataAsync()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetSaveDataAsyncCoroutine_003Ed__58))]
		private static IEnumerator GetSaveDataAsyncCoroutine(AsyncSaveOperation asyncOp)
		{
			return null;
		}

		public static void RecordAsync()
		{
		}

		[IteratorStateMachine(typeof(_003CAppendConversationDataAsync_003Ed__60))]
		private static IEnumerator AppendConversationDataAsync(StringBuilder sb)
		{
			return null;
		}

		public static byte[] GetRawData()
		{
			return null;
		}

		public static AsyncRawDataOperation GetRawDataAsync()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetRawDataAsyncCoroutine_003Ed__64))]
		private static IEnumerator GetRawDataAsyncCoroutine(AsyncRawDataOperation asyncOp)
		{
			return null;
		}

		private static void WriteValue(BinaryWriter writer, LuaValue value)
		{
		}

		private static void WriteTable(BinaryWriter writer, LuaTable table)
		{
		}

		public static void ApplyRawData(byte[] bytes)
		{
		}

		private static LuaValue ReadValue(BinaryReader reader)
		{
			return null;
		}

		private static void ReadTable(BinaryReader reader, LuaTable table)
		{
		}

		private static void WriteExtraData(BinaryWriter writer)
		{
		}

		private static void ApplyExtraData(BinaryReader reader)
		{
		}

		private static void PrepSimStatusForRawData(LuaTable conversationTable)
		{
		}

		[IteratorStateMachine(typeof(_003CPrepSimStatusForRawDataAsync_003Ed__73))]
		private static IEnumerator PrepSimStatusForRawDataAsync(LuaTable conversationTable)
		{
			return null;
		}

		private static int PrepConversationSimStatusForRawData(LuaTable conversationTable, int conversationID, LuaTable fieldTable, Dictionary<int, DialogueEntry> dialogueEntryCache, StringBuilder sb)
		{
			return 0;
		}

		private static void ApplySimStatusFromRawData()
		{
		}
	}
}

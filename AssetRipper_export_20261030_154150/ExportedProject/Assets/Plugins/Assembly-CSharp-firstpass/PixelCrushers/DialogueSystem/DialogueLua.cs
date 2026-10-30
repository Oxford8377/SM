using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Language.Lua;

namespace PixelCrushers.DialogueSystem
{
	public static class DialogueLua
	{
		[CompilerGenerated]
		private sealed class _003CRegisterLuaFunctionsAfterFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CRegisterLuaFunctionsAfterFrame_003Ed__16(int _003C_003E1__state)
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

		public const string SimStatus = "SimStatus";

		public const string Untouched = "Untouched";

		public const string WasDisplayed = "WasDisplayed";

		public const string WasOffered = "WasOffered";

		public static bool includeSimStatus;

		public static bool replaceSlashWithUnderscore;

		private static Dictionary<string, string> statusTable;

		private static Dictionary<string, float> relationshipTable;

		private static bool isRegistering;

		private static bool hasCachedParticipants;

		private static string cachedActorName;

		private static string cachedConversantName;

		private static string cachedActorIndex;

		private static string cachedConversantIndex;

		static DialogueLua()
		{
		}

		public static void RegisterLuaFunctions()
		{
		}

		[IteratorStateMachine(typeof(_003CRegisterLuaFunctionsAfterFrame_003Ed__16))]
		private static IEnumerator RegisterLuaFunctionsAfterFrame()
		{
			return null;
		}

		public static void InitializeChatMapperVariables()
		{
		}

		public static void AddChatMapperVariables(DialogueDatabase database, List<DialogueDatabase> loadedDatabases)
		{
		}

		public static void RemoveChatMapperVariables(DialogueDatabase database, List<DialogueDatabase> loadedDatabases)
		{
		}

		public static void SetParticipants(string actorName, string conversantName, string actorIndex = null, string conversantIndex = null)
		{
		}

		public static string GetSimStatus(DialogueEntry dialogueEntry)
		{
			return null;
		}

		public static string GetSimStatus(int conversationID, int entryID)
		{
			return null;
		}

		private static LuaTable GetSimStatusTable(int conversationID, int entryID)
		{
			return null;
		}

		public static void MarkDialogueEntryUntouched(DialogueEntry dialogueEntry)
		{
		}

		public static void MarkDialogueEntryDisplayed(DialogueEntry dialogueEntry)
		{
		}

		public static void MarkDialogueEntryOffered(DialogueEntry dialogueEntry)
		{
		}

		public static void MarkDialogueEntry(DialogueEntry dialogueEntry, string status)
		{
		}

		private static HashSet<string> GetExistingAssetNames(string arrayName, List<DialogueDatabase> loadedDatabases)
		{
			return null;
		}

		private static void AddToTable<T>(string arrayName, List<T> assets, List<DialogueDatabase> loadedDatabases, bool addRaw) where T : Asset
		{
		}

		private static void AddToVariableTable(List<Variable> variables, List<DialogueDatabase> loadedDatabases, bool addRaw)
		{
		}

		public static void AddToConversationTable(List<Conversation> conversations, List<DialogueDatabase> loadedDatabases, bool addRaw = false)
		{
		}

		public static LuaTable AddToConversationTable(LuaTable conversationTable, Conversation conversation, bool addRaw = false)
		{
			return null;
		}

		private static LuaTable AddNewDialogTableToConversationFields(LuaTable fieldTable, Conversation conversation)
		{
			return null;
		}

		public static LuaValue GetFieldLuaValue(Field field)
		{
			return null;
		}

		private static LuaValue GetVariableLuaValue(Variable field)
		{
			return null;
		}

		private static void SetFields(string record, List<Field> fields, string extraField = null)
		{
		}

		public static string FieldValueAsString(Field field)
		{
			return null;
		}

		public static string ValueAsString(FieldType fieldType, string fieldValue)
		{
			return null;
		}

		private static void RemoveFromTable<T>(string arrayName, List<T> assets, List<DialogueDatabase> loadedDatabases) where T : Asset
		{
		}

		private static void RegisterDialogueSystemFunctions()
		{
		}

		public static string RandomElement(string list)
		{
			return null;
		}

		public static string GetLocalizedText(string tableName, string elementName, string fieldName)
		{
			return null;
		}

		private static void RegisterChatMapperFunctions()
		{
		}

		private static string GetStatusKey(LuaTable asset1, LuaTable asset2)
		{
			return null;
		}

		private static string GetRelationshipKey(LuaTable actor1, LuaTable actor2, string relationshipType)
		{
			return null;
		}

		private static string SanitizeForStatusTable(string s)
		{
			return null;
		}

		private static float GetLuaFloat(LuaNumber luaNumber)
		{
			return 0f;
		}

		public static string GetStatus(LuaTable asset1, LuaTable asset2)
		{
			return null;
		}

		public static void SetStatus(LuaTable asset1, LuaTable asset2, string statusValue)
		{
		}

		public static float GetRelationship(LuaTable actor1, LuaTable actor2, string relationshipType)
		{
			return 0f;
		}

		public static void SetRelationship(LuaTable actor1, LuaTable actor2, string relationshipType, float value)
		{
		}

		public static void IncRelationship(LuaTable actor1, LuaTable actor2, string relationshipType, float incrementAmount)
		{
		}

		public static void DecRelationship(LuaTable actor1, LuaTable actor2, string relationshipType, float decrementAmount)
		{
		}

		public static string GetStatusTableAsLua()
		{
			return null;
		}

		public static string GetRelationshipTableAsLua()
		{
			return null;
		}

		public static void RefreshStatusTableFromLua()
		{
		}

		public static void RefreshRelationshipTableFromLua()
		{
		}

		public static string DoubleQuotesToSingle(string s)
		{
			return null;
		}

		public static string SpacesToUnderscores(string s)
		{
			return null;
		}

		public static string StringToTableIndex(string s)
		{
			return null;
		}

		public static string StringToLocalizedTableIndex(string s)
		{
			return null;
		}

		public static string StringToFieldName(string s)
		{
			return null;
		}

		public static string StringToLocalizedFieldName(string s)
		{
			return null;
		}

		public static bool DoesTableElementExist(string table, string element)
		{
			return false;
		}

		public static Lua.Result GetTableField(string table, string element, string field)
		{
			return default(Lua.Result);
		}

		public static void SetTableField(string table, string element, string field, object value)
		{
		}

		public static Lua.Result GetActorField(string actor, string field)
		{
			return default(Lua.Result);
		}

		public static void SetActorField(string actor, string field, object value)
		{
		}

		public static Lua.Result GetItemField(string item, string field)
		{
			return default(Lua.Result);
		}

		public static void SetItemField(string item, string field, object value)
		{
		}

		public static Lua.Result GetQuestField(string quest, string field)
		{
			return default(Lua.Result);
		}

		public static void SetQuestField(string quest, string field, object value)
		{
		}

		public static Lua.Result GetLocationField(string location, string field)
		{
			return default(Lua.Result);
		}

		public static void SetLocationField(string location, string field, object value)
		{
		}

		public static string[] GetAllVariables()
		{
			return null;
		}

		public static bool DoesVariableExist(string variable)
		{
			return false;
		}

		public static Lua.Result GetVariable(string variable)
		{
			return default(Lua.Result);
		}

		public static void SetVariable(string variable, object value)
		{
		}

		public static Lua.Result GetLocalizedTableField(string table, string element, string field)
		{
			return default(Lua.Result);
		}

		public static void SetLocalizedTableField(string table, string element, string field, object value)
		{
		}

		public static Lua.Result GetLocalizedActorField(string actor, string field)
		{
			return default(Lua.Result);
		}

		public static void SetLocalizedActorField(string actor, string field, object value)
		{
		}

		public static Lua.Result GetLocalizedItemField(string item, string field)
		{
			return default(Lua.Result);
		}

		public static void SetLocalizedItemField(string item, string field, object value)
		{
		}

		public static Lua.Result GetLocalizedQuestField(string quest, string field)
		{
			return default(Lua.Result);
		}

		public static void SetLocalizedQuestField(string quest, string field, object value)
		{
		}

		public static Lua.Result GetLocalizedLocationField(string location, string field)
		{
			return default(Lua.Result);
		}

		public static void SetLocalizedLocationField(string location, string field, object value)
		{
		}

		public static Lua.Result GetConversationField(int conversationID, string field)
		{
			return default(Lua.Result);
		}

		public static Lua.Result GetLocalizedConversationField(int conversationID, string field)
		{
			return default(Lua.Result);
		}
	}
}

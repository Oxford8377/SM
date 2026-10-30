using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Language.Lua
{
	public class LuaTable : LuaValue
	{
		[CompilerGenerated]
		private sealed class _003Cget_Keys_003Ed__27 : IEnumerable<LuaValue>, IEnumerable, IEnumerator<LuaValue>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private LuaValue _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public LuaTable _003C_003E4__this;

			private int _003Cindex_003E5__2;

			private Dictionary<LuaValue, LuaValue>.KeyCollection.Enumerator _003C_003E7__wrap2;

			LuaValue IEnumerator<LuaValue>.Current
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
			public _003Cget_Keys_003Ed__27(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<LuaValue> IEnumerable<LuaValue>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private List<LuaValue> list;

		private Dictionary<LuaValue, LuaValue> dict;

		private Dictionary<int, LuaValue> m_intKeyCache;

		private Dictionary<string, LuaValue> m_stringKeyCache;

		public LuaTable MetaTable { get; set; }

		public override object Value => null;

		public int Length => 0;

		public int Count => 0;

		public List<LuaValue> List => null;

		public Dictionary<LuaValue, LuaValue> Dict => null;

		public IEnumerable<LuaValue> ListValues => null;

		public IEnumerable<LuaValue> Keys
		{
			[IteratorStateMachine(typeof(_003Cget_Keys_003Ed__27))]
			get
			{
				return null;
			}
		}

		public IEnumerable<KeyValuePair<LuaValue, LuaValue>> KeyValuePairs => null;

		public LuaTable()
		{
		}

		public LuaTable(LuaTable parent)
		{
		}

		public override string GetTypeCode()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void AddRaw(string key, LuaValue value)
		{
		}

		public void AddRaw(int key, LuaValue value)
		{
		}

		public bool ContainsKey(LuaValue key)
		{
			return false;
		}

		public void AddValue(LuaValue value)
		{
		}

		public void InsertValue(int index, LuaValue value)
		{
		}

		public bool Remove(LuaValue item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public void Sort()
		{
		}

		public void Sort(LuaFunction compare)
		{
		}

		public LuaValue GetValue(int index)
		{
			return null;
		}

		public LuaValue GetValue(string name)
		{
			return null;
		}

		public LuaValue GetKey(string key)
		{
			return null;
		}

		public void SetNameValue(string name, LuaValue value)
		{
		}

		private void RemoveKey(string name)
		{
		}

		public void SetKeyValue(LuaValue key, LuaValue value)
		{
		}

		private bool GetIntValue(LuaValue value, out int intValue)
		{
			intValue = default(int);
			return false;
		}

		private void RemoveKey(LuaValue key)
		{
		}

		public LuaValue GetValue(LuaValue key)
		{
			return null;
		}

		private LuaValue GetValueFromMetaTable(string name)
		{
			return null;
		}

		private LuaValue GetValueFromMetaTable(LuaValue key)
		{
			return null;
		}

		public LuaFunction Register(string name, LuaFunc function)
		{
			return null;
		}

		public LuaFunction RegisterMethodFunction(string name, object target, MethodInfo methodInfo)
		{
			return null;
		}

		public LuaValue RawGetValue(LuaValue key)
		{
			return null;
		}

		public void RawSetValue(string name, LuaValue value)
		{
		}
	}
}

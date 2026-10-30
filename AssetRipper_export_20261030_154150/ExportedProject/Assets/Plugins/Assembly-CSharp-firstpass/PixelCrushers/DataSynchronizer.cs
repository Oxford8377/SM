using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class DataSynchronizer : MonoBehaviour, IMessageHandler
	{
		public const string DataSourceValueChangedMessage = "Data Source Value Changed";

		public const string RequestDataSourceChangeValueMessage = "Request Data Source Change Value";

		[SerializeField]
		[Tooltip("A name to associate with the data source. Data change messages that reference this name will invoke the value update events.")]
		private string m_dataSourceName;

		[SerializeField]
		private ObjectUnityEvent m_onRequestDataSourceChangeValue;

		public string dataSourceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObjectUnityEvent onRequestDataSourceChangeValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnMessage(MessageArgs messageArgs)
		{
		}

		public void DataSourceValueChanged(object newValue)
		{
		}
	}
}

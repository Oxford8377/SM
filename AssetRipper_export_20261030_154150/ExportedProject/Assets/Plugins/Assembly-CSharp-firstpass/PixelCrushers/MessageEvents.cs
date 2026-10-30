using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	[AddComponentMenu(null)]
	public class MessageEvents : MonoBehaviour, IMessageHandler
	{
		[Serializable]
		public class MessageEvent
		{
			[Tooltip("(Optional) If set, only react to messages sent from this sender.")]
			public GameObject requiredSender;

			[Tooltip("(Optional) If set, only react to messages sent to this target.")]
			public GameObject requiredTarget;

			[Tooltip("Listen for this message.")]
			public StringField message;

			[Tooltip("(Optional) If set, listen for this parameter with the message.")]
			public StringField parameter;

			public MessageArgsEvent onMessage;
		}

		[Serializable]
		public class MessageToSend
		{
			[Tooltip("(Optional) If set, specify this GameObject as the message target.")]
			public GameObject target;

			[Tooltip("Send this message.")]
			public StringField message;

			[Tooltip("(Optional) If set, send this parameter with the message.")]
			public StringField parameter;
		}

		[SerializeField]
		private MessageEvent[] m_messagesToListenFor;

		[SerializeField]
		private MessageToSend[] m_messagesToSend;

		public MessageEvent[] messagesToListenFor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MessageToSend[] messagesToSend
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

		public virtual void OnMessage(MessageArgs messageArgs)
		{
		}

		protected virtual bool IsParticipantOk(GameObject requiredParticipant, object actualParticipant)
		{
			return false;
		}

		public virtual void SendToMessageSystem(int index)
		{
		}
	}
}

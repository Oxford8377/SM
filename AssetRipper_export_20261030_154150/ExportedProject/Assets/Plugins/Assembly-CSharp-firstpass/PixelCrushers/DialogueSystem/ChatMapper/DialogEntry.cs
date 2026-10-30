using System.Collections.Generic;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	public class DialogEntry
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlAttribute("IsRoot")]
		public bool IsRoot;

		[XmlAttribute("IsGroup")]
		public bool IsGroup;

		[XmlAttribute("NodeColor")]
		public string NodeColor;

		[XmlAttribute("DelaySimStatus")]
		public bool DelaySimStatus;

		[XmlAttribute("FalseCondtionAction")]
		public string FalseCondtionAction;

		[XmlAttribute("ConditionPriority")]
		public string ConditionPriority;

		[XmlArrayItem("Field")]
		[XmlArray("Fields")]
		public List<Field> Fields;

		[XmlArray("OutgoingLinks")]
		[XmlArrayItem("Link")]
		public List<Link> OutgoingLinks;

		public string ConditionsString;

		public string UserScript;
	}
}

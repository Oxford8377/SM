using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	[Serializable]
	public class Assets
	{
		[XmlArray("Actors")]
		[XmlArrayItem("Actor")]
		public List<Actor> Actors;

		[XmlArray("Items")]
		[XmlArrayItem("Item")]
		public List<Item> Items;

		[XmlArray("Locations")]
		[XmlArrayItem("Location")]
		public List<Location> Locations;

		[XmlArrayItem("Conversation")]
		[XmlArray("Conversations")]
		public List<Conversation> Conversations;

		[XmlArrayItem("UserVariable")]
		[XmlArray("UserVariables")]
		public List<UserVariable> UserVariables;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RainEngine.BL.Abstract;

namespace RainEngine.BL
{
	[Category("Прочие компоненты")]
	[Serializable]
	public class ComponentDictionary : Dictionary<Type, Abstract.Component>, IXmlSerializable
	{

		public System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(System.Xml.XmlReader reader)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(string));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(Abstract.Component));

			bool wasEmpty = reader.IsEmptyElement;
			reader.Read();

			if (wasEmpty)
				return;

			while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
			{
				reader.ReadStartElement("item");

				reader.ReadStartElement("key");
				Type key = Type.GetType((string)keySerializer.Deserialize(reader));
				reader.ReadEndElement();

				reader.ReadStartElement("value");
				Abstract.Component value = (Abstract.Component)valueSerializer.Deserialize(reader);
				reader.ReadEndElement();

				this.Add(key, value);

				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}

		public void WriteXml(System.Xml.XmlWriter writer)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(string));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(Abstract.Component));

			foreach (Type key in this.Keys)
			{
				writer.WriteStartElement("item");

				writer.WriteStartElement("key");
				keySerializer.Serialize(writer, key.FullName);
				writer.WriteEndElement();

				writer.WriteStartElement("value");
				Abstract.Component value = this[key];
				valueSerializer.Serialize(writer, value);
				writer.WriteEndElement();

				writer.WriteEndElement();
			}
		}

		#region hided base properties

		[Browsable(false)]
		new public int Count
		{
			get
			{
				return base.Count;
			}
		}

		[Browsable(false)]
		new public IEqualityComparer<Type> Comparer
		{
			get
			{
				return base.Comparer;
			}
		}

		[Browsable(false)]
		new public KeyCollection Keys
		{
			get { return base.Keys; }
		}

		[Browsable(true)]
		[DisplayName("Компоненты")]
		new public ValueCollection Values
		{
			get { return base.Values;  }
		}
		#endregion

		public ComponentDictionary() : base() {}

		public override string ToString()
		{
			return "Адаптер коллекции компонентов";
		}
	}
}

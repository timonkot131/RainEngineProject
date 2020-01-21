using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RainEngine.BL;
using RainEngine.BL.Components;

namespace RainEngine.BL.Abstract
{
	public enum Shapes
	{
		Circle,
		Square,
		StickMan,
		Arrow_Vertical,
		Arrow_Horizontal
	}

	[Serializable]
    public class SceneObject : ICloneable
    {
        private int x;
		private int y;
		private int scaleX;
		private int scaleY;
		private string name;
		private Point upLeftCorner;
		private ComponentDictionary components = new ComponentDictionary();

		public SceneObject()
		{

		}
		
		public SceneObject(string name, int x, int y, int scaleX, int scaleY)
		{
			this.name = name;
			this.x = x;
			this.y = y;
			this.scaleX = scaleX;
			this.scaleY = scaleY;
			ChangeUpLeftCorner();
		}

		[Category("прочие компоненты")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		[DisplayName("Компоненты")]
		public ComponentDictionary Components
		{
			get
			{
				return components;
			}
			set
			{
				components = value;
			}
		}

		private void ChangeUpLeftCorner()
		{
			if (scaleY < 0 && scaleX < 0)
			{
				upLeftCorner.X = x + scaleX;
				upLeftCorner.Y = y + scaleY;
			}
			else if (scaleY < 0 && scaleX > 0)
			{
				upLeftCorner.X = x;
				upLeftCorner.Y = y + scaleY;
			}
			else if (scaleY > 0 && scaleX < 0)
			{
				upLeftCorner.X = x + scaleX;
				upLeftCorner.Y = y;
			}
			else
			{
				upLeftCorner.X = x;
				upLeftCorner.Y = y;
			}
		}

		[Browsable(true)]
		[Description("X coordinate of object")]
		[DisplayName("X")]
		[Category("Инспектор")]
		public int X
		{
			get { return x; }
			set
			{
				x = value;
				ChangeUpLeftCorner();
			}
		}
		[Browsable(true)]
		[Description("Y coordinate of object")]
		[DisplayName("Y")]
		[Category("Инспектор")]
		public int Y
		{
			get { return y; }
			set
			{
				y = value;
				ChangeUpLeftCorner();
			}
		}

		[Browsable(true)]
		[Description("X scale of object")]
		[DisplayName("Scale_x")]
		[Category("Инспектор")]
		public int ScaleX
		{
			get { return scaleX; }
			set
			{
				if (value < 1)
				{
					scaleX = 1;
				}
				else
				{
					scaleX = value;
					ChangeUpLeftCorner();
				}
			}
		}
		[Browsable(true)]
		[Description("Y scale of object")]
		[DisplayName("Scale_y")]
		[Category("Инспектор")]
		public int ScaleY
		{
			get { return scaleY; }
			set
			{
				if (value < 1)
				{
					scaleY = 1;
				}
				else
				{
					scaleY = value;
					ChangeUpLeftCorner();
				}
			}
		}
		[Browsable(true)]
		[Description("Name of object")]
		[DisplayName("Name")]
		[Category("Инспектор")]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		[Browsable(false)]
		public Point UpLeftCorner
		{
			get { return upLeftCorner; }
		}

		public object Clone()
		{
			var cloned = new SceneObject(name, x, y, scaleX, scaleY);
			foreach(var keyValue in components)
			{
				cloned.components.Add(keyValue.Key, (Component)keyValue.Value.Clone(cloned));
			}
			return cloned;
		}


		public T AttachComponent<T>() where T : Component, new()
		{
			try
			{
				T component = new T() { Target = this };
				components.Add(typeof(T), component);
				return component;
			}
			catch (ArgumentException e)
			{
				throw e;
			}
			
		}

		public SceneObject AttachComponent(Component component)
		{
			component.Target = this;
			components.Add(component.GetType(), component);

			return this;
		}

		public T GetComponent<T>() where T : Component
		{
			try
			{
				T component = components[typeof(T)] as T;
				return component;
			}
			catch (IndexOutOfRangeException)
			{
				return null;
			}
		}

		public void RemoveComponent<T>() where T : Component
		{
			components.Remove(typeof(T));
		}
		public void RemoveComponentByType(Component component)
		{
			components.Remove(component.GetType());
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
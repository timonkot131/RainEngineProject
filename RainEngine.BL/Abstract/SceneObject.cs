using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RainEngine.BL;

namespace RainEngine.BL.Abstract
{
    [Serializable]
    [XmlInclude(typeof(VectorObject))]
    [XmlInclude(typeof(RasterObject))]
    [XmlInclude(typeof(EmptyObject))]
    public abstract class SceneObject
    {
        protected int x;
        protected int y;
        protected int scaleX;
        protected int scaleY;
        protected string name;
        protected Point upLeftCorner;
		protected ComponentDictionary components = new ComponentDictionary();
        public abstract void Create(Graphics graphics, Pen pen);

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

		public abstract int X
        {
            get;
            set;
        }

        public abstract int Y
        {
            get;
            set;
        }


        public abstract int ScaleX
        {
            get;
            set;
        }

        public abstract int ScaleY
        {
            get;
            set;
        }

        public abstract string Name
        {
            get;
            set;
        }
        public abstract Point UpLeftCorner
        {
            get;
        }

    }
}
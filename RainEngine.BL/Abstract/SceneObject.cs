using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        protected int scale_x;
        protected int scale_y;
        protected string name;
        protected Point upLeftCorner;
        public abstract void Create(Graphics graphics, Pen pen);

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


        public abstract int Scale_x
        {
            get;
            set;
        }

        public abstract int Scale_y
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
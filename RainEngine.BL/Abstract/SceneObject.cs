using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine.BL.Abstract
{
    public abstract class SceneObject
    {
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

        public abstract SceneObject Type
        {
            get;
        }
    }
}
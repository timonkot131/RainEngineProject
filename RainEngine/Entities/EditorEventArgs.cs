using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.BL;
using RainEngine.BL.Abstract;

namespace RainEngine.Entities
{
    public class EditorEventArgs : EventArgs
    {

        public EditorEventArgs(int X, int Y, int IndeciesCount, SceneObject SelectedObject, Graphics Graph)
        {
            this.X = X;
            this.Y = Y;
            this.IndeciesCount = IndeciesCount;
            this.SelectedObject = SelectedObject;
            this.Graph = Graph;
        }
        public EditorEventArgs(int X, int Y, int IndeciesCount, Graphics Graph)
        {
            this.X = X;
            this.Y = Y;
            this.IndeciesCount = IndeciesCount;
            SelectedObject = new EmptyObject();
            this.Graph = Graph;
        }
        public EditorEventArgs(Graphics Graph)
        {
            X = 0;
            Y = 0;
            IndeciesCount = 0;
            SelectedObject = new EmptyObject();
            this.Graph = Graph;
        }
        public Graphics Graph { get; private set; }
        public int X { get; private set; }

        public int Y { get; private set; }

        public int IndeciesCount { get; private set; }

        public SceneObject SelectedObject { get; private set; }

    }
}

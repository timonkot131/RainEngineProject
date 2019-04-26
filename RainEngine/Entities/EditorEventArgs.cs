using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainEngine.Entities
{
    public class EditorEventArgs : EventArgs
    {

        public EditorEventArgs(int X, int Y, int IndeciesCount, int SelectedIndex, Graphics Graph)
        {
            this.X = X;
            this.Y = Y;
            this.IndeciesCount = IndeciesCount;
            this.SelectedIndex = SelectedIndex;
            this.Graph = Graph;
        }
        public EditorEventArgs(int IndeciesCount, int SelectedIndex, Graphics Graph)
        {
            X = 0;
            Y = 0;
            this.IndeciesCount = IndeciesCount;
            this.SelectedIndex = SelectedIndex;
            this.Graph = Graph;
        }
        public Graphics Graph { get; private set; }
        public int X { get; private set; }

        public int Y { get; private set; }

        public int IndeciesCount { get; private set; }

        public int SelectedIndex { get; private set; }
    }
}

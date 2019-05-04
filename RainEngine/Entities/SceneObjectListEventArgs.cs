using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RainEngine.Entities
{
    public class SceneObjectListEventArgs:EventArgs
    {
       
        public SceneObjectListEventArgs(int ItemIndex)
        {
            this.Item = ItemIndex;
        }
        public int Item { get; private set; }

        public Graphics Graph { get; set; }
    }
}

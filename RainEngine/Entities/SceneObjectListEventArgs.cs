using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine.Entities
{
    public class SceneObjectListEventArgs:EventArgs
    {
       
        public SceneObjectListEventArgs(int ItemIndex)
        {
            this.ItemIndex = ItemIndex;
        }
        public int ItemIndex { get; private set; }
    }
}

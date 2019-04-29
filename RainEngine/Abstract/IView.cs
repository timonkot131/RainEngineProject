using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.Entities;

namespace RainEngine.Abstract
{
    interface IView
    {
        OpenFileDialog OpenFileDialog { get; set; }

        SaveFileDialog SaveFileDialog { get; set; }

        PropertyGrid PropertyGrid { get; set; }        

        void UpdateScenabsData(string[] scenabnames, Bitmap[] scenabimgs);

        void UpdateSceneObjectsData(IEnumerable<string> SceneObjectsNames);

        void ClearGraphics();

        event EventHandler<MouseEventArgs> MouseDownEvent;

        event EventHandler<EditorEventArgs> MouseUpEvent;

        event EventHandler<EditorEventArgs> MouseMoveEvent;

        event EventHandler<EditorEventArgs> ClearClick;

        event EventHandler<EventArgs> SaveToXMLClick;

        event EventHandler<EditorEventArgs> OpenFromXMLClick;

        event EventHandler<SceneObjectListEventArgs> SelectedIndexChanged;

        event EventHandler<EditorEventArgs> PropertyValueChanged;
    }
}


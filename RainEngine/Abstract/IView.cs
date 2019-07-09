using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.BL.Abstract;
using RainEngine.Entities;

namespace RainEngine.Abstract
{
	public interface IView
	{
		OpenFileDialog OpenFileDialog { get; set; }

		SaveFileDialog SaveFileDialog { get; set; }

		PropertyGrid PropertyGrid { get; set; }

		void UpdateScenabsData(List<SceneObject> scenabs, Bitmap[] scenabimgs);

		void UpdateSceneObjectsData(List<SceneObject> SceneObjs);

		void ClearGraphics();

		void ChangeCursor(Cursor cursor);

		event EventHandler<EditorEventArgs> MouseDownEvent;

		event EventHandler<EditorEventArgs> MouseUpEvent;

		event EventHandler<EditorEventArgs> PressedMouseMoveEvent;

		event EventHandler<EditorEventArgs> MouseMoveEvent;

		event EventHandler<EditorEventArgs> ClearClick;

		event EventHandler<EventArgs> SaveToXMLClick;

		event EventHandler<EditorEventArgs> OpenFromXMLClick;

		event EventHandler<SceneObjectListEventArgs> ListBoxSelectedIndexChanged;

		event EventHandler<SceneObjectListEventArgs> ListViewSelectedIndexChanged;

		event EventHandler<EditorEventArgs> PropertyValueChanged;
	}
}


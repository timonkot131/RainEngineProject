﻿using System;
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
        void UpdateScenabsData(string[] scenabnames, Bitmap[] scenabimgs);
        void UpdateSceneObjectsData(IEnumerable<string> SceneObjectsNames);

        event EventHandler<MouseEventArgs> MouseDownEvent;

        event EventHandler<EditorEventArgs> MouseUpEvent;

        event EventHandler<EditorEventArgs> MouseMoveEvent;

        event EventHandler<EditorEventArgs> ClearClick;
    }
}
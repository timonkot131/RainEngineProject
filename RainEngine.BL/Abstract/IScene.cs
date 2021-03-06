﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine.BL.Abstract
{
    public interface IScene:IModel
    {
        void AddNewObject(SceneObject obj);
        void ClearObjects();
        void UpdateGraphicsFromScene(Graphics graph, Pen pen);
        SceneObject GetSceneObject(int id);
        List<SceneObject> SceneObjects { get;}
        IEnumerable<SceneObject> GetObjectsQuery(Func<SceneObject, bool> condition);
    }
}

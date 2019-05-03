using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine.BL.Abstract
{
    public interface IScene:IModel
    {
        void AddNewObject(VectorObject obj);
        void ClearObjects();
        void UpdateGraphicsFromScene(Graphics graph, Pen pen);
        VectorObject GetSceneObject(int id);
        IEnumerable<string> SceneObjectsNames { get;}
        IEnumerable<VectorObject> GetObjectsQuery(Func<VectorObject, bool> condition);
    }
}

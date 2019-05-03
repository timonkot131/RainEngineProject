using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RainEngine.BL.Abstract;

namespace RainEngine.BL
{
    public class Scene:IModel,IScene
    {
        public void LoadXmlFile(string filepath)
        {
            try
            {
                XDocument xDoc = XDocument.Load(filepath);
                XElement xScene = xDoc.Element("Scene");
                IEnumerable<XElement> xSceneObjects =
                    from xSceneObject in xScene.Elements()
                    select xSceneObject;
                foreach (XElement xSceneObject in xSceneObjects)
                {
                    Enum.TryParse(xSceneObject.Element("Shape").Value, out VectorObject.Shapes shape);
                    VectorObject sceneObject = new VectorObject(
                        Convert.ToInt32(xSceneObject.Element("Coordinates").Element("X").Value),
                        Convert.ToInt32(xSceneObject.Element("Coordinates").Element("Y").Value),
                        Convert.ToInt32(xSceneObject.Element("Scale").Element("X").Value),
                        Convert.ToInt32(xSceneObject.Element("Scale").Element("Y").Value),
                        shape);
                    sceneObject.Name = xSceneObject.Attribute("Name").Value;
                    sceneObjects.Add(sceneObject);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }
        }

        public void SaveXmlFile(string filepath)
        {
            try
            {
                XDocument xDoc = new XDocument
                    (
                      new XElement("Scene")
                    );
                foreach (VectorObject sceneObject in sceneObjects)
                {
                    xDoc.Element("Scene").Add(
                        new XElement("SceneObject",
                        new XAttribute("Name", sceneObject.Name),
                            new XElement("Shape", sceneObject.Shape),
                            new XElement("Coordinates",
                                new XElement("X", sceneObject.X),
                                new XElement("Y", sceneObject.Y)),
                            new XElement("Scale",
                                new XElement("X", sceneObject.Scale_x),
                                new XElement("Y", sceneObject.Scale_y))
                       )
                   );
                }
                xDoc.Declaration = new XDeclaration("1.0", "utf-8", "true");
                xDoc.Save(filepath);
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }
        }

        private List<VectorObject> sceneObjects;

        public Scene()
        {
            sceneObjects = new List<VectorObject>();
        }

        public void AddNewObject(VectorObject obj)
        {
            obj.Name = obj.Shape.ToString() + Postfix(obj);
            sceneObjects.Add(obj);
        }

        public void ClearObjects()
        {
            sceneObjects.Clear();
        }

        public void UpdateGraphicsFromScene(Graphics graph, Pen pen)
        {
            foreach (VectorObject obj in sceneObjects)
            {
                switch (obj.Shape)
                {
                    case VectorObject.Shapes.Circle:
                        graph.DrawEllipse(pen, obj.X, obj.Y, obj.Scale_x, obj.Scale_y);
                        break;
                    case VectorObject.Shapes.Square:
                        graph.DrawPolygon(pen, new Point[]
                        {
                            new Point(obj.X,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y+obj.Scale_y),
                            new Point(obj.X,obj.Y+obj.Scale_y)

                        });
                        break;
                    case VectorObject.Shapes.StickMan:
                        FigureDrawing.MakeStickMan(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, pen);
                        break;
                    case VectorObject.Shapes.Arrow_Vertical:
                        FigureDrawing.MakeArrowVertical(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, pen);
                        break;
                    case VectorObject.Shapes.Arrow_Horizontal:
                        FigureDrawing.MakeArrowHorizontal(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, pen);
                        break;
                }
            }
        }
        public VectorObject GetSceneObject(int id)
        {
            return sceneObjects[id];
        }

        public IEnumerable<string> SceneObjectsNames
        {
            get
            {
                var names = from scenobj in sceneObjects
                            select scenobj.Name;
                return names;
            }
        }
        
        public IEnumerable<VectorObject> GetObjectsQuery(Func<VectorObject,bool> condition)
        {
            return sceneObjects.Where(condition);
        }

        private string Postfix(VectorObject obj)
        {

            int query = sceneObjects.Count(p => p.Shape == obj.Shape);
            if (query != 0)
                return "(" + query + ")";
            else return "";

        }
    }
}

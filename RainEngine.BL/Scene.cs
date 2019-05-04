using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using RainEngine.BL.Abstract;

namespace RainEngine.BL
{
    public class Scene:IScene
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
                        xSceneObject.Attribute("Name").Value,
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

        private List<SceneObject> sceneObjects;

        public Scene()
        {
            sceneObjects = new List<SceneObject>();
        }

        public void AddNewObject(SceneObject obj)
        {
            obj.Name += Postfix(obj);
            sceneObjects.Add(obj);
            string box = "";
            foreach(SceneObject object1 in sceneObjects)
            {
                box += object1.Name+"\n";
            }
            MessageBox.Show(box);
        }

        public void ClearObjects()
        {
            sceneObjects.Clear();
        }

        public void UpdateGraphicsFromScene(Graphics graph, Pen pen)
        {
            foreach (SceneObject obj in sceneObjects)
            {
                obj.Create(graph, pen);
            }
        }
        public SceneObject GetSceneObject(int id)
        {
            return sceneObjects[id];
        }

        public List<SceneObject> SceneObjects
        {
            get
            {
                return sceneObjects;
            }
        }
        
        public IEnumerable<SceneObject> GetObjectsQuery(Func<SceneObject,bool> condition)
        {
            return sceneObjects.Where(condition);
        }

        private string Postfix(SceneObject obj)
        {

            int query = sceneObjects.Count(p => p.Name == obj.Name);
            if (query != 0)
                return "(" + query + ")";
            else return "";

        }
    }
}

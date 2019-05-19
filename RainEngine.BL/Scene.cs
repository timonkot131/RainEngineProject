using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;
using RainEngine.BL.Abstract;

namespace RainEngine.BL
{
    public class Scene:IScene
    {
        private List<SceneObject> sceneObjects;

        public void LoadXmlFile(string filepath)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<SceneObject>));

                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    sceneObjects = (List<SceneObject>)formatter.Deserialize(fs);
                }
                
                //XDocument xDoc = XDocument.Load(filepath);
                //XElement xScene = xDoc.Element("Scene");
                //IEnumerable<XElement> xSceneObjects =
                //    from xSceneObject in xScene.Elements()
                //    select xSceneObject;
                //foreach (XElement xSceneObject in xSceneObjects)
                //{
                //    Enum.TryParse(xSceneObject.Element("Shape").Value, out VectorObject.Shapes shape);
                //    VectorObject sceneObject = new VectorObject(
                //        xSceneObject.Attribute("Name").Value,
                //        Convert.ToInt32(xSceneObject.Element("Coordinates").Element("X").Value),
                //        Convert.ToInt32(xSceneObject.Element("Coordinates").Element("Y").Value),
                //        Convert.ToInt32(xSceneObject.Element("Scale").Element("X").Value),
                //        Convert.ToInt32(xSceneObject.Element("Scale").Element("Y").Value),
                //        shape);
                //    sceneObject.Name = xSceneObject.Attribute("Name").Value;
                //    sceneObjects.Add(sceneObject);
                //}
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
                XmlSerializer formatter = new XmlSerializer(typeof(List<SceneObject>));

                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, sceneObjects);
                }

                //XDocument xDoc = new XDocument
                //    (
                //      new XElement("Scene")
                //    );
                //foreach (SceneObject sceneObject in sceneObjects)
                //{
                //    VectorObject scn = (VectorObject)sceneObject;
                //    if(sceneObject is VectorObject)

                //    xDoc.Element("Scene").Add(
                //        new XElement("SceneObject",
                //        new XAttribute("Name", sceneObject.Name),
                //        new XAttribute("Type", sceneObject.Type),
                //            new XElement("Shape", (VectorObject)sceneObject.Shape),
                //            new XElement("Coordinates",
                //                new XElement("X", sceneObject.X),
                //                new XElement("Y", sceneObject.Y)),
                //            new XElement("Scale",
                //                new XElement("X", sceneObject.Scale_x),
                //                new XElement("Y", sceneObject.Scale_y)),
                //            new XElement("UpLeftCorner",
                //                new XElement("X", sceneObject.UpLeftCorner.X),
                //                new XElement("Y", sceneObject.UpLeftCorner.X))
                //       )
                //   );
                //}
                //xDoc.Declaration = new XDeclaration("1.0", "utf-8", "true");
                //xDoc.Save(filepath);
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }
        }

        public Scene()
        {
            sceneObjects = new List<SceneObject>();
        }

        public void AddNewObject(SceneObject obj)
        {
            sceneObjects.Add(obj);
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

    }
}

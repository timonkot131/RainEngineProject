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
using RainEngine.BL.Components;

namespace RainEngine.BL
{
	public class Scene : IScene
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
			}
			catch (Exception e)
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
			}
			catch (Exception e)
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
				obj.GetComponent<Drawer>().Draw(graph, pen);
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

		public IEnumerable<SceneObject> GetObjectsQuery(Func<SceneObject, bool> condition)
		{
			return sceneObjects.Where(condition);
		}

	}
}

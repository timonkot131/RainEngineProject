using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine;
using RainEngine.BL;
using RainEngine.BL.Abstract;

namespace RainEngine
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IScene modelscene = new Scene();
            MainForm view = new MainForm();
			EditorStart startView = new EditorStart(view);

            RainPresenter presenter = new RainPresenter(modelscene,view);

            Application.Run(startView);
        }
    }
}

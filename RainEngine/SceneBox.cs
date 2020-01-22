using RainEngine.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainEngine
{
	public class SceneBox : PictureBox
	{
		int y = 0;
		Timer timer = new Timer();
		Pen colourPen = new Pen(Color.Black, 3);

		public IScene Scene { get; set; }

		public SceneBox()
		{
			timer.Interval = 1;
			timer.Enabled = true;
			timer.Tick += Timer1_Tick;
			DoubleBuffered = true;
		}

		DateTime frameRenderTime;
		double renderTime = 0;
		double framerate = 0;

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			pe.Graphics.DrawString(framerate.ToString()+" fps", SystemFonts.DefaultFont, Brushes.Black, 0, 0);
			
			renderTime = (DateTime.UtcNow - frameRenderTime).TotalMilliseconds;
			framerate = 1000 / renderTime;
			frameRenderTime = DateTime.UtcNow;
			Render(pe);
		}

		private void Render(PaintEventArgs pe)
		{
			if(Scene != null)
			{
				Scene.UpdateGraphicsFromScene(pe.Graphics, colourPen);
				Overlay.DrawOverlay(pe.Graphics);
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			y++;
			Refresh();
		}
	}
}

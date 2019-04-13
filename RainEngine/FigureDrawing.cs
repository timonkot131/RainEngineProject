using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine
{
    static class FigureDrawing
    {
        static public void MakeStickMan(Graphics graph,int firstpos_X,int firstpos_Y,int width,int height, Pen pen)
        {
            graph.DrawLine(pen, firstpos_X + width / 2f, firstpos_Y + height / 4f, firstpos_X + width / 2f, firstpos_Y + height / 1.33f);
            graph.DrawLine(pen, firstpos_X, firstpos_Y + height, firstpos_X + width / 2f, firstpos_Y + height / 1.33f);
            graph.DrawLine(pen, firstpos_X + width / 2f, firstpos_Y + height / 1.33f, firstpos_X + width, firstpos_Y + height);
            graph.DrawLine(pen, firstpos_X, firstpos_Y + height / 4f, firstpos_X + width / 2f, firstpos_Y + height / 2f);
            graph.DrawLine(pen, firstpos_X + width / 2f, firstpos_Y + height / 2f,firstpos_X+width,firstpos_Y+height/4f);
            graph.DrawEllipse(pen, firstpos_X + width * 0.25f, firstpos_Y, width / 2f, height / 4f);
        }

        static public void MakeArrowUp(Graphics graph, int firstpos_X, int firstpos_Y, int width, int height, Pen pen)
        {

        }

        static public void MakeArrowDown(Graphics graph, int firstpos_X, int firstpos_Y, int width, int height, Pen pen)
        {

        }

        static public void MakeArrowLeft(Graphics graph, int firstpos_X, int firstpos_Y, int width, int height, Pen pen)
        {

        }

        static public void MakeArrowRight(Graphics graph, int firstpos_X, int firstpos_Y, int width, int height, Pen pen)
        {

        }
    }
}

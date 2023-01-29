using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainingFormsGame3
{
    public class RectClass
    {
        public RectClass(string color = "Red", int posx = 0, int posy = 0, int sizex = 20, int sizey = 20)
        {
            if (color == "Red")
            {
                this.color = Color.Red;
            }
            else
            {
                this.color = Color.White;
            }

            this.posx = posx;
            this.posy = posy;
            this.sizex = sizex;
            this.sizey = sizey;
        }

        public Color color { get; set; }
        public int posx { get; set; }
        public int posy { get; set; }
        public int sizex { get; set; }
        public int sizey { get; set; }
        public bool inMotion { get; set; }

        public void DrawRect(int _posx, int _posy, int _xsize, int _ysize, Form1 _form)
        {
            var myBrush = new SolidBrush(Color.Red);

            this.posx = _posx;

            // Brush is used to set the color of the Filled Rectangle Color
            //if (rectExist)
            //{
            //    myBrush.Color = Color.Red;
            //    rectExist = false;
            //}
            //else
            //{
            //    myBrush.Color = Color.White;
            //    rectExist = true;
            //}

            // Graphics is the object for the Form (GDI+ Drawing Surface)
            // We then create the graphics which is a reference to the Form1 Object
            // If we its possible to remove the this statement as we are still in 
            // context of this Form (This Form being referenced as Form1)
            Graphics formGraphics;
            formGraphics = _form.CreateGraphics();
            formGraphics.FillRectangle(myBrush, _posx, _posy, _xsize, _ysize);
            myBrush.Dispose();
            formGraphics.Dispose();

            //rectExist = true;
        }
    }
}

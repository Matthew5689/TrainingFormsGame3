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
    }
}

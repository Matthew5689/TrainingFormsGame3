using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingFormsGame3
{
    public partial class Form1 : Form
    {
        static bool rectExist = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
            }

            if (rectExist)
            {
                DrawRect(0, 0, 100, 100);
            }
            else
            {
                DrawRect(0, 0, 100, 100);
            }
        }

        public void DrawRect(int posx, int posy, int xsize, int ysize)
        {
            var myBrush = new SolidBrush(Color.White);

            // Brush is used to set the color of the Filled Rectangle Color
            if (rectExist)
            {
                myBrush.Color = Color.Red;
                rectExist = false;
            }
            else
            {
                myBrush.Color = Color.White;
                rectExist = true;
            }

            // Graphics is the object for the Form (GDI+ Drawing Surface)
            // We then create the graphics which is a reference to the Form1 Object
            // If we its possible to remove the this statement as we are still in 
            // context of this Form (This Form being referenced as Form1)
            Graphics formGraphics;
            formGraphics = CreateGraphics();
            formGraphics.FillRectangle(myBrush, posx, posy, xsize, ysize);
            myBrush.Dispose();
            formGraphics.Dispose();

            //rectExist = true;
        }
    }
}

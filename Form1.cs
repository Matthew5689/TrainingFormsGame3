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
        public static RectClass myRect = new RectClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
            //}

            //myRect.DrawRect(myRect.posx+1, myRect.posy, myRect.sizex, myRect.sizey, this);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyValue}' consumed.");
            }

            if (e.KeyValue == 87)
            {
                myRect.inMotion();
            }

            myRect.DrawRect(myRect.posx + 1, myRect.posy, myRect.sizex, myRect.sizey, this);
        }
    }
}

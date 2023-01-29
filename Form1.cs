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

            //if (rectExist)
            //{
            //    DrawRect(0, 0, 100, 100);
            //}
            //else
            //{
            //    DrawRect(0, 0, 100, 100);
            //}
        }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMOv01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCocomo1_Click(object sender, EventArgs e)
        {
            Basic fB = new Basic();
            fB.Show();
        }

        private void buttonCocomo2_Click(object sender, EventArgs e)
        {
            Prom fB = new Prom();
            fB.Show();
        }

        private void buttonCocomo31_Click(object sender, EventArgs e)
        {
            COCOMO2Predvarit fB = new COCOMO2Predvarit();
            fB.Show();
        }

        private void buttonCocomo32_Click(object sender, EventArgs e)
        {
            COCOMO2Det fB = new COCOMO2Det();
            fB.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "Лицензионное соглашение.pdf";
            Process.Start(filename);
        }

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            string filename = "Справка.pdf";
            Process.Start(filename);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            string filename = "Об Авторе.pdf";
            Process.Start(filename);
        }
    }
}

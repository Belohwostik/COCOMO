using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace COCOMOv01
{
    public partial class Basic : Form
    {
        double a = 2.4, b=1.05, c=2.5, d=0.38;
        double pm, tm;

        public Basic()
        {
            InitializeComponent();
            cb_TypePrj.SelectedIndex = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Basic_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_razmerCoda_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_TM_Click(object sender, EventArgs e)
        {

        }

        private void lba_tm_Click(object sender, EventArgs e)
        {

        }

        private void lba_d_Click(object sender, EventArgs e)
        {

        }
        static int GetDecimalDigitsCount(double number) //К-во знаков после запятой
        {
            string str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
            return str.Contains(".") ? str.Remove(0, Math.Truncate(number).ToString().Length + 1).Length : 0;
        }
        private void btn_rezult_Click(object sender, EventArgs e)
        {
            if (tb_razmerCoda.Text == "") //Проверка на ввод цифр
            {
                lb_CodeError.Visible = true;
                return;
            }

            if (GetDecimalDigitsCount(Convert.ToDouble(tb_razmerCoda.Text)) > 3)
            {
                lb_CodeError.Visible = true;
                return;
            }
            else lb_CodeError.Visible = false;
            pm = a * Pow(Convert.ToDouble(tb_razmerCoda.Text), b);
            tm = c * Pow(pm, d);
            lba_pm.Text = pm.ToString("0.###");
            lba_tm.Text = tm.ToString("0.###");
        }

        private void tb_razmerCoda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | (e.KeyChar == ',' && !tb_razmerCoda.Text.Contains(','))) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void cb_TypePrj_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_TypePrj.SelectedIndex) //Выьор типа проекта по индексу и изменение параметров
            {
                case 0: 
                        {
                        a = 2.4;
                        b =1.05;
                        c =2.5;
                        d =0.38;
                        break;
                    }
                case 1:
                    {
                        a =3.0;
                        b =1.12;
                        c =2.5;
                        d =0.35;
                        break;
                    }
                case 2:
                    {
                        a =3.6;
                        b =1.20;
                        c =2.5;
                        d =0.32;
                        break;
                    }
            }

            lba_a.Text = a.ToString();
            lba_b.Text = b.ToString();
            lba_c.Text = c.ToString();
            lba_d.Text = d.ToString();
        }
    }
}

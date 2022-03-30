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
    public partial class COCOMO2Predvarit : Form
    {
        //Факторы масштаба
        double prec = 3.72, //Прецедентность, наличие опыта аналогичных разработок
               flex = 3.04, //Гибкость процесса разработки 
               resl = 4.24, //Архитектура и разрешение рисков
               team = 3.29, //Сработанность команды
               pmat = 4.68, //Зрелость процессов 
               sf;

        //Множетели трудоемкости
        double E,

               pers = 1.00, //квалификация персонала
               prex = 1.00, //опыт персонала
               rcpx = 1.00, //сложность и надежность продукта
               ruse = 1.00, //сложность платформы разработки
               pdif = 1.00, //оборудование
               fcil = 1.00, //инструменты простейшие
               sced = 1.00, //требуемое выполнение графика работ
               pm, tm, eaf;
        public COCOMO2Predvarit()
        {
            InitializeComponent();

            cb_PREC.SelectedIndex = 2;
            cb_FLEX.SelectedIndex = 2;
            cb_RESL.SelectedIndex = 2;
            cb_TEAM.SelectedIndex = 2;
            cb_PMAT.SelectedIndex = 2;

            cb_PERS.SelectedIndex = 3;
            cb_PREX.SelectedIndex = 3;
            cb_RCPX.SelectedIndex = 3;
            cb_RUSE.SelectedIndex = 1;
            cb_PDIF.SelectedIndex = 1;
            cb_FCIL.SelectedIndex = 3;
            cb_SCED.SelectedIndex = 2;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lba_E_Click(object sender, EventArgs e)
        {

        }

        private void lb_razmCoda_Click(object sender, EventArgs e)
        {

        }

        private void lba_tm_Click(object sender, EventArgs e)
        {

        }

        //Факторы масштаба
        private void cb_PREC_SelectedIndexChanged(object sender, EventArgs e)//Прецедентность, наличие опыта аналогичных разработок
        {
            switch (cb_PREC.SelectedIndex)
            {

                case 0:
                    {
                        prec = 6.20;
                        break;
                    }
                case 1:
                    {
                        prec = 4.96;
                        break;
                    }
                case 2:
                    {
                        prec = 3.72;
                        break;
                    }
                case 3:
                    {
                        prec = 2.48;
                        break;
                    }
                case 4:
                    {
                        prec = 1.24;
                        break;
                    }
                case 5:
                    {
                        prec = 0.00;
                        break;
                    }

            }

            lba_PREC.Text = prec.ToString();

        }
        private void cb_FLEX_SelectedIndexChanged(object sender, EventArgs e)//Гибкость процесса разработки 
        {
            switch (cb_FLEX.SelectedIndex)
            {

                case 0:
                    {
                        flex = 5.07;
                        break;
                    }
                case 1:
                    {
                        flex = 4.05;
                        break;
                    }
                case 2:
                    {
                        flex = 3.04;
                        break;
                    }
                case 3:
                    {
                        flex = 2.03;
                        break;
                    }
                case 4:
                    {
                        flex = 1.01;
                        break;
                    }
                case 5:
                    {
                        flex = 0.00;
                        break;
                    }

            }

            lba_FLEX.Text = flex.ToString();

        }
        private void cb_RESL_SelectedIndexChanged(object sender, EventArgs e)//Архитектура и разрешение рисков
        {
            switch (cb_RESL.SelectedIndex)
            {

                case 0:
                    {
                        resl = 7.07;
                        break;
                    }
                case 1:
                    {
                        resl = 5.65;
                        break;
                    }
                case 2:
                    {
                        resl = 4.24;
                        break;
                    }
                case 3:
                    {
                        resl = 2.83;
                        break;
                    }
                case 4:
                    {
                        resl = 1.41;
                        break;
                    }
                case 5:
                    {
                        resl = 0.00;
                        break;
                    }

            }

            lba_RESL.Text = resl.ToString();

        }
        private void cb_TEAM_SelectedIndexChanged(object sender, EventArgs e)//Сработанность команды
        {
            switch (cb_TEAM.SelectedIndex)
            {

                case 0:
                    {
                        team = 5.48;
                        break;
                    }
                case 1:
                    {
                        team = 4.38;
                        break;
                    }
                case 2:
                    {
                        team = 3.29;
                        break;
                    }
                case 3:
                    {
                        team = 2.19;
                        break;
                    }
                case 4:
                    {
                        team = 1.10;
                        break;
                    }
                case 5:
                    {
                        team = 0.00;
                        break;
                    }

            }

            lba_TEAM.Text = team.ToString();

        }
        private void cb_PMAT_SelectedIndexChanged(object sender, EventArgs e)//Зрелость процессов 
        {
            switch (cb_PMAT.SelectedIndex)
            {

                case 0:
                    {
                        pmat = 7.80;
                        break;
                    }
                case 1:
                    {
                        pmat = 6.24;
                        break;
                    }
                case 2:
                    {
                        pmat = 4.68;
                        break;
                    }
                case 3:
                    {
                        pmat = 3.12;
                        break;
                    }
                case 4:
                    {
                        pmat = 1.56;
                        break;
                    }
                case 5:
                    {
                        pmat = 0.00;
                        break;
                    }

            }

            lba_PMAT.Text = pmat.ToString();

        }

        //Множетели трудоемкости
        private void cb_PERS_SelectedIndexChanged(object sender, EventArgs e)//квалификация персонала
        {
            switch (cb_PERS.SelectedIndex)
            {

                case 0:
                    {
                        pers = 2.12;
                        break;
                    }
                case 1:
                    {
                        pers = 1.62;
                        break;
                    }
                case 2:
                    {
                        pers = 1.26;
                        break;
                    }
                case 3:
                    {
                        pers = 1.00;
                        break;
                    }
                case 4:
                    {
                        pers = 0.83;
                        break;
                    }
                case 5:
                    {
                        pers = 0.63;
                        break;
                    }
                case 6:
                    {
                        pers = 0.50;
                        break;
                    }

            }

            lba_PERS.Text = pers.ToString();

        }
        private void cb_PREX_SelectedIndexChanged(object sender, EventArgs e)//опыт персонала
        {
            switch (cb_PREX.SelectedIndex)
            {

                case 0:
                    {
                        prex = 1.59;
                        break;
                    }
                case 1:
                    {
                        prex = 1.33;
                        break;
                    }
                case 2:
                    {
                        prex = 1.22;
                        break;
                    }
                case 3:
                    {
                        prex = 1.00;
                        break;
                    }
                case 4:
                    {
                        prex = 0.87;
                        break;
                    }
                case 5:
                    {
                        prex = 0.74;
                        break;
                    }
                case 6:
                    {
                        prex = 0.62;
                        break;
                    }

            }

            lba_PREX.Text = prex.ToString();

        }
        private void cb_RCPX_SelectedIndexChanged(object sender, EventArgs e)//сложность и надежность продукта
        {
            switch (cb_RCPX.SelectedIndex)
            {

                case 0:
                    {
                        rcpx = 0.49;
                        break;
                    }
                case 1:
                    {
                        rcpx = 0.60;
                        break;
                    }
                case 2:
                    {
                        rcpx = 0.83;
                        break;
                    }
                case 3:
                    {
                        rcpx = 1.00;
                        break;
                    }
                case 4:
                    {
                        rcpx = 1.33;
                        break;
                    }
                case 5:
                    {
                        rcpx = 1.91;
                        break;
                    }
                case 6:
                    {
                        rcpx = 2.72;
                        break;
                    }

            }

            lba_RCPX.Text = rcpx.ToString();

        }
        private void cb_RUSE_SelectedIndexChanged(object sender, EventArgs e)//сложность платформы разработки
        {
            switch (cb_RUSE.SelectedIndex)
            {

                case 0:
                    {
                        ruse = 0.95;
                        break;
                    }
                case 1:
                    {
                        ruse = 1.00;
                        break;
                    }
                case 2:
                    {
                        ruse = 1.07;
                        break;
                    }
                case 3:
                    {
                        ruse = 1.15;
                        break;
                    }
                case 4:
                    {
                        ruse = 1.24;
                        break;
                    }

            }

            lba_RUSE.Text = ruse.ToString();

        }
        private void cb_PDIF_SelectedIndexChanged(object sender, EventArgs e)//оборудование 
        {
            switch (cb_PDIF.SelectedIndex)
            {

                case 0:
                    {
                        pdif = 0.87;
                        break;
                    }
                case 1:
                    {
                        pdif = 1.00;
                        break;
                    }
                case 2:
                    {
                        pdif = 1.29;
                        break;
                    }
                case 3:
                    {
                        pdif = 1.81;
                        break;
                    }
                case 4:
                    {
                        pdif = 2.61;
                        break;
                    }

            }

            lba_PDIF.Text = pdif.ToString();

        }
        private void cb_FCIL_SelectedIndexChanged(object sender, EventArgs e)//инструменты простейшие
        {
            switch (cb_FCIL.SelectedIndex)
            {

                case 0:
                    {
                        fcil = 1.43;
                        break;
                    }
                case 1:
                    {
                        fcil = 1.30;
                        break;
                    }
                case 2:
                    {
                        fcil = 1.10;
                        break;
                    }
                case 3:
                    {
                        fcil = 1.00;
                        break;
                    }
                case 4:
                    {
                        fcil = 0.87;
                        break;
                    }
                case 5:
                    {
                        fcil = 0.73;
                        break;
                    }

                case 6:
                    {
                        fcil = 0.62;
                        break;
                    }

            }

            lba_FCIL.Text = fcil.ToString();

        }
        private void cb_SCED_SelectedIndexChanged(object sender, EventArgs e)//требуемое выполнение графика работ
        {
            switch (cb_SCED.SelectedIndex)
            {

                case 0:
                    {
                        sced = 1.43;
                        break;
                    }
                case 1:
                    {
                        sced = 1.14;
                        break;
                    }
                case 2:
                    {
                        sced = 1.00;
                        break;
                    }
                case 3:
                    {
                        sced = 1.00;
                        break;
                    }

            }

            lba_SCED.Text = sced.ToString();

        }


        private void tb_razmerCoda_KeyPress(object sender, KeyPressEventArgs e) //Ввод к-ва строк
        {
            if (Char.IsDigit(e.KeyChar) | (e.KeyChar == ',' && !tb_razmerCoda.Text.Contains(','))) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        private void tb_razmerCoda_TextChanged(object sender, EventArgs e)
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

            eaf = pers * prex * rcpx *
              ruse * pdif * fcil * sced;

            sf = prec + flex + resl + team + pmat;
            E = 0.91 + (0.01 * sf);
            pm = eaf * 2.94 * Pow(Convert.ToDouble(tb_razmerCoda.Text), E);
            lba_pm.Text = pm.ToString("0.###");

            eaf = pers * prex * rcpx *
              ruse * pdif * fcil;
            pm = eaf * 2.94 * Pow(Convert.ToDouble(tb_razmerCoda.Text), E);
            tm = sced * 3.67 * Pow(pm, (0.28 + 0.2 * (E - 0.91)));
            
            lba_tm.Text = tm.ToString("0.###");
            
            lba_eaf.Text = eaf.ToString("0.###");
            lba_sf.Text = sf.ToString("0.###");
        }
    }
}

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

    public partial class Prom : Form
    {
        double a = 3.2, b = 1.05, c = 2.5, d = 0.38, //Коэффициенты уровня

           Nadejn = 1.00, //Требуемая надежность ПО
           RazmerBD = 1.00, //Размер БД приложения
           sloshnProd = 1.00, //Сложность продукта

           ogranichVipoln = 1.00, //Ограничения быстродействия
           pamyati = 1.00, //Ограничения памяти
           neystOkrVirt = 1.00, //Неустойчивость окружения
           trebVremVosst = 1.00, //Требуемое время восстановления

           analirSpos = 1.00, //Аналитические способности
           opitRazrab = 1.00, //Опыт разработки
           sposobRazrabPO = 1.00, //Способности к разработке
           opitIspVirtMachin = 1.00, //Опыт использования виртуальных машин 
           opitRazrabYP = 1.00, //Опыт разработки на языках программ-я 

           primMethRazrab = 1.00, //Применение методов
           IspInstrumRazrab = 1.00, //Использование инструментария
           TrebSoblGraph = 1.00, //Соблюденияе графика
           pm, tm, eaf;

        

        public Prom()
        {
            InitializeComponent();
            cb_TypePrj.SelectedIndex = 0;

            cb_Nadejn.SelectedIndex = 2;
            cb_RazmerBD.SelectedIndex = 1;
            cb_sloshnProd.SelectedIndex = 2;
            
            cb_ogranichVipoln.SelectedIndex = 0;
            cb_pamyati.SelectedIndex = 0;
            cb_neystOkrVirt.SelectedIndex = 1;
            cb_trebVremVosst.SelectedIndex = 1;

            cb_analirSpos.SelectedIndex = 2;
            cb_opitRazrab.SelectedIndex = 2;
            cb_sposobRazrabPO.SelectedIndex = 2;
            cb_opitIspVirtMachin.SelectedIndex = 2;
            cb_opitRazrabYP.SelectedIndex = 2;

            cb_primMethRazrab.SelectedIndex = 2;
            cb_IspInstrumRazrab.SelectedIndex = 2;
            cb_TrebSoblGraph.SelectedIndex = 2;
        }

        static int GetDecimalDigitsCount(double number) //К-во знаков после запятой
        {
            string str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
            return str.Contains(".") ? str.Remove(0, Math.Truncate(number).ToString().Length + 1).Length : 0;
        }

        private void btn_rezult_Click(object sender, EventArgs e)
        {
            if (tb_razmerCoda.Text == "" ) //Проверка на ввод цифр
            {
                lb_CodeError.Visible = true;
                return;
            }

            if (GetDecimalDigitsCount(Convert.ToDouble(tb_razmerCoda.Text))>3)
            {
                lb_CodeError.Visible = true;
                return;
            }

            else lb_CodeError.Visible = false;
            eaf = Nadejn * RazmerBD * sloshnProd *
                ogranichVipoln * pamyati * neystOkrVirt * trebVremVosst *
                analirSpos * opitRazrab * sposobRazrabPO * opitIspVirtMachin * opitRazrabYP *
                primMethRazrab * IspInstrumRazrab * TrebSoblGraph;

            pm = eaf * a * Pow(Convert.ToDouble(tb_razmerCoda.Text), b);
            tm = c * Pow(pm, d);
            lba_pm.Text = pm.ToString("0.###");
            lba_tm.Text = tm.ToString("0.###");
            lba_eaf.Text = eaf.ToString("0.###");
        }
        private void tb_razmerCoda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)| (e.KeyChar == ',' && !tb_razmerCoda.Text.Contains(','))) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_razmerCoda_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_eaf_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        
        //Характеристики продукта
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Требуемая надежность ПО
        {
            switch (cb_Nadejn.SelectedIndex)
            {
                case 0:
                    {
                        Nadejn = 0.75;
                        break;
                    }
                case 1:
                    {
                        Nadejn = 0.88;
                        break;
                    }
                case 2:
                    {
                        Nadejn = 1.00;
                        break;
                    }
                case 3:
                    {
                        Nadejn = 1.15;
                        break;
                    }
                case 4:
                    {
                        Nadejn = 1.40;
                        break;
                    }
            }

            lbN_Nadejn.Text = Nadejn.ToString();
        }
        private void cb_RazmerBD_SelectedIndexChanged(object sender, EventArgs e) //Размер БД приложения
        {
            switch (cb_RazmerBD.SelectedIndex)
            {
                case 0:
                    {
                        RazmerBD = 0.94;
                        break;
                    }
                case 1:
                    {
                        RazmerBD = 1.00;
                        break;
                    }
                case 2:
                    {
                        RazmerBD = 1.08;
                        break;
                    }
                case 3:
                    {
                        RazmerBD = 1.16;
                        break;
                    }
            }

            lbN_RazmerBD.Text = RazmerBD.ToString();
        }
        private void cb_sloshnProd_SelectedIndexChanged(object sender, EventArgs e) //Сложность продукта
        {
            switch (cb_sloshnProd.SelectedIndex)
            {
                case 0:
                    {
                        sloshnProd = 0.70;
                        break;
                    }
                case 1:
                    {
                        sloshnProd = 0.85;
                        break;
                    }
                case 2:
                    {
                        sloshnProd = 1.00;
                        break;
                    }
                case 3:
                    {
                        sloshnProd = 1.15;
                        break;
                    }
                case 4:
                    {
                        sloshnProd = 1.30;
                        break;
                    }
                case 5:
                    {
                        sloshnProd = 1.65;
                        break;
                    }
            }

            lbN_sloshnProd.Text = sloshnProd.ToString();
        }
        //Характеристики аппаратного обеспечения
        private void cb_ogranichVipoln_SelectedIndexChanged(object sender, EventArgs e) //Ограничения быстродействия при выполненни программы
        {
            switch (cb_ogranichVipoln.SelectedIndex)
            {
                case 0:
                    {
                        ogranichVipoln = 1.00;
                        break;
                    }
                case 1:
                    {
                        ogranichVipoln = 1.11;
                        break;
                    }
                case 2:
                    {
                        ogranichVipoln = 1.30;
                        break;
                    }
                case 3:
                    {
                        ogranichVipoln = 1.66;
                        break;
                    }
            }

            lbN_ogranichVipoln.Text = ogranichVipoln.ToString();
        }
        private void cb_pamyati_SelectedIndexChanged(object sender, EventArgs e) //Ограничения памяти
        {
            switch (cb_pamyati.SelectedIndex)
            {
                case 0:
                    {
                        pamyati = 1.00;
                        break;
                    }
                case 1:
                    {
                        pamyati = 1.06;
                        break;
                    }
                case 2:
                    {
                        pamyati = 1.21;
                        break;
                    }
                case 3:
                    {
                        pamyati = 1.56;
                        break;
                    }
            }

            lbN_pamyati.Text = pamyati.ToString();
        }
        private void cb_neystOkrVirt_SelectedIndexChanged(object sender, EventArgs e) //Неустойчивость окружения виртуальной машины
        {
            switch (cb_neystOkrVirt.SelectedIndex)
            {
                case 0:
                    {
                        neystOkrVirt = 0.87;
                        break;
                    }
                case 1:
                    {
                        neystOkrVirt = 1.00;
                        break;
                    }
                case 2:
                    {
                        neystOkrVirt = 1.15;
                        break;
                    }
                case 3:
                    {
                        neystOkrVirt = 1.3;
                        break;
                    }
            }

            lbN_neystOkrVirt.Text = neystOkrVirt.ToString();
        }
        private void cb_trebVremVosst_SelectedIndexChanged(object sender, EventArgs e) //Требуемое время восстановления
        {
            switch (cb_trebVremVosst.SelectedIndex)
            {
                case 0:
                    {
                        trebVremVosst = 0.87;
                        break;
                    }
                case 1:
                    {
                        trebVremVosst = 1.00;
                        break;
                    }
                case 2:
                    {
                        trebVremVosst = 1.07;
                        break;
                    }
                case 3:
                    {
                        trebVremVosst = 1.15;
                        break;
                    }
            }

            lbN_trebVremVosst.Text = trebVremVosst.ToString();
        }
        //Характеристики персонала
        private void cb_analirSpos_SelectedIndexChanged(object sender, EventArgs e) //Аналитические способности
        {
            switch (cb_analirSpos.SelectedIndex)
            {
                case 0:
                    {
                        analirSpos = 1.46;
                        break;
                    }
                case 1:
                    {
                        analirSpos = 1.19;
                        break;
                    }
                case 2:
                    {
                        analirSpos = 1.00;
                        break;
                    }
                case 3:
                    {
                        analirSpos = 0.86;
                        break;
                    }
                case 4:
                    {
                        analirSpos = 0.71;
                        break;
                    }
            }

            lbN_analirSpos.Text = analirSpos.ToString();
        }
        private void cb_opitRazrab_SelectedIndexChanged(object sender, EventArgs e) //Опыт разработки
        {
            switch (cb_opitRazrab.SelectedIndex)
            {
                case 0:
                    {
                        opitRazrab = 1.29;
                        break;
                    }
                case 1:
                    {
                        opitRazrab = 1.13;
                        break;
                    }
                case 2:
                    {
                        opitRazrab = 1.00;
                        break;
                    }
                case 3:
                    {
                        opitRazrab = 0.91;
                        break;
                    }
                case 4:
                    {
                        opitRazrab = 0.82;
                        break;
                    }
            }

            lbN_opitRazrab.Text = opitRazrab.ToString();
        }
        private void cb_sposobRazrabPO_SelectedIndexChanged(object sender, EventArgs e) //Способности к разработке ПО
        {
            switch (cb_sposobRazrabPO.SelectedIndex)
            {
                case 0:
                    {
                        sposobRazrabPO = 1.42;
                        break;
                    }
                case 1:
                    {
                        sposobRazrabPO = 1.17;
                        break;
                    }
                case 2:
                    {
                        sposobRazrabPO = 1.00;
                        break;
                    }
                case 3:
                    {
                        sposobRazrabPO = 0.86;
                        break;
                    }
                case 4:
                    {
                        sposobRazrabPO = 0.70;
                        break;
                    }
            }

            lbN_sposobRazrabPO.Text = sposobRazrabPO.ToString();
        }
        private void cb_opitIspVirtMachin_SelectedIndexChanged(object sender, EventArgs e)//Опыт использования виртуальных машин 
        {
            switch (cb_opitIspVirtMachin.SelectedIndex)
            {

                case 0:
                    {
                        opitIspVirtMachin = 1.21;
                        break;
                    }
                case 1:
                    {
                        opitIspVirtMachin = 1.1;
                        break;
                    }
                case 2:
                    {
                        opitIspVirtMachin = 1.0;
                        break;
                    }
                case 3:
                    {
                        opitIspVirtMachin = 0.9;
                        break;
                    }

            }

            lbN_opitIspVirtMachin.Text = opitIspVirtMachin.ToString();

        }
        private void cb_opitRazrabYP_SelectedIndexChanged(object sender, EventArgs e)//Опыт разработки на языках программ-я 
        {
            switch (cb_opitRazrabYP.SelectedIndex)
            {

                case 0:
                    {
                        opitRazrabYP = 1.14;
                        break;
                    }
                case 1:
                    {
                        opitRazrabYP = 1.07;
                        break;
                    }
                case 2:
                    {
                        opitRazrabYP = 1.0;
                        break;
                    }
                case 3:
                    {
                        opitRazrabYP = 0.95;
                        break;
                    }

            }

            cb_opitRazrabYP.Text = opitRazrabYP.ToString();

        }
        //Характеристики проекта
        private void cb_primMethRazrab_SelectedIndexChanged(object sender, EventArgs e)//Применение методов разработки ПО
        {
            switch (cb_primMethRazrab.SelectedIndex)
            {

                case 0:
                    {
                        primMethRazrab = 1.24;
                        break;
                    }
                case 1:
                    {
                        primMethRazrab = 1.10;
                        break;
                    }
                case 2:
                    {
                        primMethRazrab = 1.0;
                        break;
                    }
                case 3:
                    {
                        primMethRazrab = 0.91;
                        break;
                    }
                case 4:
                    {
                        primMethRazrab = 0.82;
                        break;
                    }

            }

            cb_primMethRazrab.Text = primMethRazrab.ToString();

        }
        private void cb_IspInstrumRazrab_SelectedIndexChanged(object sender, EventArgs e)//Использование инструментария разработки ПО
        {
            switch (cb_IspInstrumRazrab.SelectedIndex)
            {

                case 0:
                    {
                        IspInstrumRazrab = 1.24;
                        break;
                    }
                case 1:
                    {
                        IspInstrumRazrab = 1.1;
                        break;
                    }
                case 2:
                    {
                        IspInstrumRazrab = 1.0;
                        break;
                    }
                case 3:
                    {
                        IspInstrumRazrab = 0.91;
                        break;
                    }
                case 4:
                    {
                        IspInstrumRazrab = 0.83;
                        break;
                    }

            }

            cb_IspInstrumRazrab.Text = IspInstrumRazrab.ToString();

        }
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e) //Требования соблюдения графика разработки
        {
            switch (cb_TrebSoblGraph.SelectedIndex)
            {

                case 0:
                    {
                        TrebSoblGraph = 1.23;
                        break;
                    }
                case 1:
                    {
                        TrebSoblGraph = 1.08;
                        break;
                    }
                case 2:
                    {
                        TrebSoblGraph = 1.0;
                        break;
                    }
                case 3:
                    {
                        TrebSoblGraph = 1.04;
                        break;
                    }
                case 4:
                    {
                        TrebSoblGraph = 1.1;
                        break;
                    }

            }

            cb_TrebSoblGraph.Text = TrebSoblGraph.ToString();

        }


        private void lb_RazmerBD_Click(object sender, EventArgs e)
        {

        }

        private void lb_ogranichVipoln_Click(object sender, EventArgs e)
        {

        }

        private void lb_opitIspVirtMachin_Click(object sender, EventArgs e)
        {

        }

        private void Prom_Load(object sender, EventArgs e)
        {

        }

        private void cb_TypePrj_SelectedIndexChanged(object sender, EventArgs e) //Выбор типа проекта по индексу и изменение параметров
        {
            switch (cb_TypePrj.SelectedIndex) 
            {
                case 0:
                    {
                        a = 3.2;
                        b = 1.05;
                        c = 2.5;
                        d = 0.38;
                        break;
                    }
                case 1:
                    {
                        a = 3.0;
                        b = 1.12;
                        c = 2.5;
                        d = 0.35;
                        break;
                    }
                case 2:
                    {
                        a = 2.8;
                        b = 1.20;
                        c = 2.5;
                        d = 0.32;
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


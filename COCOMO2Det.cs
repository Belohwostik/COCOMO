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
    public partial class COCOMO2Det : Form
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

                                   acap = 1.00, //возможности аналитика
                                   aexp = 1.00, //опыт разработки приложений
                                   pcap = 1.00, //возможности программиста
                                   pcon = 1.00, //продолжительность работы персонала
                                   pexp = 1.00, //опыт работы с платформой
                                   ltex = 1.00, //опыт использования ЯП и инструментальных средств

                                   rely = 1.00, //требуемая надежность программы
                                   data = 1.00, //размер базы данных
                                   cplx = 1.00, //сложность программы
                                   ruse = 1.00, //требуемая возможность многократного использ-ия
                                   docu = 1.00, //соответствие документации потребностям жизненного цикла

                                   time = 1.00, //ограничения времени выполнения
                                   stor = 1.00, //ограничения памяти
                                   pvol = 1.00, //изменяемость платформы

                                   tool = 1.00, //использование инструментальных программных средств
                                   site = 1.00, //многоабонентская разработка
                                   sced = 1.00, //требуемое выполнение графика работ

               pm, tm, eaf;

        public COCOMO2Det()
        {
            InitializeComponent();
            cb_PREC.SelectedIndex = 2;
            cb_FLEX.SelectedIndex = 2;
            cb_RESL.SelectedIndex = 2;
            cb_TEAM.SelectedIndex = 2;
            cb_PMAT.SelectedIndex = 2;

            cb_ACAP.SelectedIndex = 2;
            cb_AEXP.SelectedIndex = 2;
            cb_PCAP.SelectedIndex = 2;
            cb_PCON.SelectedIndex = 2;
            cb_PEXP.SelectedIndex = 2;
            cb_LTEX.SelectedIndex = 2;

            cb_RELY.SelectedIndex = 2;
            cb_DATA.SelectedIndex = 1;
            cb_CPLX.SelectedIndex = 2;
            cb_RUSE.SelectedIndex = 1;
            cb_DOCU.SelectedIndex = 2;

            cb_TIME.SelectedIndex = 0;
            cb_STOR.SelectedIndex = 0;
            cb_PVOL.SelectedIndex = 1;

            cb_TOOL.SelectedIndex = 2;
            cb_SITE.SelectedIndex = 2;
            cb_SCED.SelectedIndex = 2;
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
        //Факторы персонала
        private void cb_ACAP_SelectedIndexChanged(object sender, EventArgs e)//возможности аналитика
        {
            switch (cb_ACAP.SelectedIndex)
            {

                case 0:
                    {
                        acap = 1.42;
                        break;
                    }
                case 1:
                    {
                        acap = 1.29;
                        break;
                    }
                case 2:
                    {
                        acap = 1.00;
                        break;
                    }
                case 3:
                    {
                        acap = 0.85;
                        break;
                    }
                case 4:
                    {
                        acap = 0.71;
                        break;
                    }

            }

            lba_ACAP.Text = acap.ToString();

        }
        private void cb_AEXP_SelectedIndexChanged(object sender, EventArgs e)//опыт разработки приложений
        {
            switch (cb_AEXP.SelectedIndex)
            {

                case 0:
                    {
                        aexp = 1.22;
                        break;
                    }
                case 1:
                    {
                        aexp = 1.10;
                        break;
                    }
                case 2:
                    {
                        aexp = 1.00;
                        break;
                    }
                case 3:
                    {
                        aexp = 0.88;
                        break;
                    }
                case 4:
                    {
                        aexp = 0.81;
                        break;
                    }

            }

            lba_AEXP.Text = aexp.ToString();

        }

        private void cb_PCAP_SelectedIndexChanged(object sender, EventArgs e)//возможности программиста
        {
            switch (cb_PCAP.SelectedIndex)
            {

                case 0:
                    {
                        pcap = 1.34;
                        break;
                    }
                case 1:
                    {
                        pcap = 1.15;
                        break;
                    }
                case 2:
                    {
                        pcap = 1.00;
                        break;
                    }
                case 3:
                    {
                        pcap = 0.88;
                        break;
                    }
                case 4:
                    {
                        pcap = 0.76;
                        break;
                    }

            }

            lba_PCAP.Text = pcap.ToString();

        }
        private void cb_PCON_SelectedIndexChanged(object sender, EventArgs e)//продолжительность работы персонала
        {
            switch (cb_PCON.SelectedIndex)
            {

                case 0:
                    {
                        pcon = 1.29;
                        break;
                    }
                case 1:
                    {
                        pcon = 1.12;
                        break;
                    }
                case 2:
                    {
                        pcon = 1.00;
                        break;
                    }
                case 3:
                    {
                        pcon = 0.90;
                        break;
                    }
                case 4:
                    {
                        pcon = 0.81;
                        break;
                    }

            }

            lba_PCON.Text = pcon.ToString();

        }
        private void cb_PEXP_SelectedIndexChanged(object sender, EventArgs e)//опыт работы с платформой
        {
            switch (cb_PEXP.SelectedIndex)
            {

                case 0:
                    {
                        pexp = 1.19;
                        break;
                    }
                case 1:
                    {
                        pexp = 1.09;
                        break;
                    }
                case 2:
                    {
                        pexp = 1.00;
                        break;
                    }
                case 3:
                    {
                        pexp = 0.91;
                        break;
                    }
                case 4:
                    {
                        pexp = 0.85;
                        break;
                    }

            }

            lba_PEXP.Text = pexp.ToString();

        }
        private void cb_LTEX_SelectedIndexChanged(object sender, EventArgs e)//опыт использования ЯП и инструментальных средств
        {
            switch (cb_LTEX.SelectedIndex)
            {

                case 0:
                    {
                        ltex = 1.20;
                        break;
                    }
                case 1:
                    {
                        ltex = 1.09;
                        break;
                    }
                case 2:
                    {
                        ltex = 1.00;
                        break;
                    }
                case 3:
                    {
                        ltex = 0.91;
                        break;
                    }
                case 4:
                    {
                        ltex = 0.84;
                        break;
                    }

            }

            lba_LTEX.Text = ltex.ToString();

        }

        //Факторы продукта
        private void cb_analirSpos_SelectedIndexChanged(object sender, EventArgs e)//требуемая надежность программы
        {
            switch (cb_RELY.SelectedIndex)
            {

                case 0:
                    {
                        rely = 0.84;
                        break;
                    }
                case 1:
                    {
                        rely = 0.92;
                        break;
                    }
                case 2:
                    {
                        rely = 1.00;
                        break;
                    }
                case 3:
                    {
                        rely = 1.10;
                        break;
                    }
                case 4:
                    {
                        rely = 1.26;
                        break;
                    }

            }

            lba_RELY.Text = rely.ToString();

        }

        private void lb_RUSE_Click(object sender, EventArgs e)
        {

        }

        private void lba_tm_Click(object sender, EventArgs e)
        {

        }

        private void cb_DATA_SelectedIndexChanged(object sender, EventArgs e)//размер базы данных
        {
            switch (cb_DATA.SelectedIndex)
            {

                case 0:
                    {
                        data = 0.23;
                        break;
                    }
                case 1:
                    {
                        data = 1.00;
                        break;
                    }
                case 2:
                    {
                        data = 1.14;
                        break;
                    }
                case 3:
                    {
                        data = 1.28;
                        break;
                    }

            }

            lba_DATA.Text = data.ToString();

        }
        private void cb_CPLX_SelectedIndexChanged(object sender, EventArgs e)//сложность программы
        {
            switch (cb_CPLX.SelectedIndex)
            {

                case 0:
                    {
                        cplx = 0.73;
                        break;
                    }
                case 1:
                    {
                        cplx = 0.87;
                        break;
                    }
                case 2:
                    {
                        cplx = 1.00;
                        break;
                    }
                case 3:
                    {
                        cplx = 1.17;
                        break;
                    }
                case 4:
                    {
                        cplx = 1.34;
                        break;
                    }
                case 5:
                    {
                        cplx = 1.74;
                        break;
                    }

            }

            lba_CPLX.Text = cplx.ToString();

        }
        private void cb_RUSE_SelectedIndexChanged(object sender, EventArgs e)//требуемая возможность многократного использ-ия
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
        private void cb_DOCU_SelectedIndexChanged(object sender, EventArgs e)//соответствие документации потребностям жизненного цикла
        {
            switch (cb_DOCU.SelectedIndex)
            {

                case 0:
                    {
                        docu = 0.81;
                        break;
                    }
                case 1:
                    {
                        docu = 0.91;
                        break;
                    }
                case 2:
                    {
                        docu = 1.00;
                        break;
                    }
                case 3:
                    {
                        docu = 1.11;
                        break;
                    }
                case 4:
                    {
                        docu = 1.23;
                        break;
                    }

            }

            lba_DOCU.Text = docu.ToString();

        }

        //Факторы платформы
        private void cb_TIME_SelectedIndexChanged(object sender, EventArgs e)//ограничения времени выполнения
        {
            switch (cb_TIME.SelectedIndex)
            {

                case 0:
                    {
                        time = 1.00;
                        break;
                    }
                case 1:
                    {
                        time = 1.11;
                        break;
                    }
                case 2:
                    {
                        time = 1.29;
                        break;
                    }
                case 3:
                    {
                        time = 1.63;
                        break;
                    }

            }

            lba_TIME.Text = time.ToString();

        }
        private void cb_STOR_SelectedIndexChanged(object sender, EventArgs e)//ограничения памяти
        {
            switch (cb_STOR.SelectedIndex)
            {

                case 0:
                    {
                        stor = 1.00;
                        break;
                    }
                case 1:
                    {
                        stor = 1.05;
                        break;
                    }
                case 2:
                    {
                        stor = 1.17;
                        break;
                    }
                case 3:
                    {
                        stor = 1.46;
                        break;
                    }

            }

           lba_STOR.Text = stor.ToString();

        }
        private void cb_PVOL_SelectedIndexChanged(object sender, EventArgs e)//изменяемость платформы
        {
            switch (cb_PVOL.SelectedIndex)
            {

                case 0:
                    {
                        pvol = 0.87;
                        break;
                    }
                case 1:
                    {
                        pvol = 1.00;
                        break;
                    }
                case 2:
                    {
                        pvol = 1.15;
                        break;
                    }
                case 3:
                    {
                        pvol = 1.30;
                        break;
                    }

            }

            lba_PVOL.Text = pvol.ToString();

        }

        //Факторы проекта
        private void cb_TOOL_SelectedIndexChanged(object sender, EventArgs e)//использование инструментальных программных средств
        {
            switch (cb_TOOL.SelectedIndex)
            {

                case 0:
                    {
                        tool = 1.17;
                        break;
                    }
                case 1:
                    {
                        tool = 1.09;
                        break;
                    }
                case 2:
                    {
                        tool = 1.00;
                        break;
                    }
                case 3:
                    {
                        tool = 0.90;
                        break;
                    }
                case 4:
                    {
                        tool = 0.78;
                        break;
                    }

            }

            lba_TOOL.Text = tool.ToString();

        }
        private void cb_SITE_SelectedIndexChanged(object sender, EventArgs e)//многоабонентская разработка
        {
            switch (cb_SITE.SelectedIndex)
            {

                case 0:
                    {
                        site = 1.22;
                        break;
                    }
                case 1:
                    {
                        site = 1.09;
                        break;
                    }
                case 2:
                    {
                        site = 1.00;
                        break;
                    }
                case 3:
                    {
                        site = 0.93;
                        break;
                    }
                case 4:
                    {
                        site = 0.86;
                        break;
                    }
                case 5:
                    {
                        site = 0.80;
                        break;
                    }

            }

            lba_SITE.Text = site.ToString();

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
                case 4:
                    {
                        sced = 1.00;
                        break;
                    }

            }

            lba_SCED.Text = sced.ToString();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tb_razmerCoda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | (e.KeyChar == ',' && !tb_razmerCoda.Text.Contains(','))) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
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

            eaf = acap * aexp * pcap * pcon * pexp * ltex * rely * data * cplx * ruse * docu * time * stor * pvol * tool * site * sced;


            sf = prec + flex + resl + team + pmat;
            E = 0.91 + (0.01 * sf);
            pm = eaf * 2.45 * Pow(Convert.ToDouble(tb_razmerCoda.Text), E);
            lba_pm.Text = pm.ToString("0.###");

            eaf = acap * aexp * pcap * pcon * pexp * ltex * rely * data * cplx * ruse * docu * time * stor * pvol * tool * site;
            pm = eaf * 2.45 * Pow(Convert.ToDouble(tb_razmerCoda.Text), E);
            tm = sced * 3.67 * Pow(pm, (0.28 + 0.2 * (E - 0.91)));

            lba_tm.Text = tm.ToString("0.###");
            lba_eaf.Text = eaf.ToString("0.###");
            lba_sf.Text = sf.ToString("0.###");
        }



        private void labelCoper_Click(object sender, EventArgs e)
        {

        }
        private void lb_Nadejn_Click(object sender, EventArgs e)
        {

        }
        private void lb_PREX_Click(object sender, EventArgs e)
        {

        }
        private void lb_FCIL_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lbN_TrebSoblGraph_Click(object sender, EventArgs e)
        {

        }
        
        private void lb_PDIF_Click(object sender, EventArgs e)
        {

        }
        private void SCED_Click(object sender, EventArgs e)
        {

        }
        
        private void label23_Click(object sender, EventArgs e)
        {

        }
        private void lb_ACAP_Click(object sender, EventArgs e)
        {

        }
    }
}

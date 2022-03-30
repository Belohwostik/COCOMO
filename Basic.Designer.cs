
namespace COCOMOv01
{
    partial class Basic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_TypePrj = new System.Windows.Forms.Label();
            this.cb_TypePrj = new System.Windows.Forms.ComboBox();
            this.lb_a = new System.Windows.Forms.Label();
            this.lb_b = new System.Windows.Forms.Label();
            this.lb_d = new System.Windows.Forms.Label();
            this.lb_c = new System.Windows.Forms.Label();
            this.lba_d = new System.Windows.Forms.Label();
            this.lba_c = new System.Windows.Forms.Label();
            this.lba_b = new System.Windows.Forms.Label();
            this.lba_a = new System.Windows.Forms.Label();
            this.lb_razmCodaEnt = new System.Windows.Forms.Label();
            this.tb_razmerCoda = new System.Windows.Forms.TextBox();
            this.lb_rezult = new System.Windows.Forms.Label();
            this.btn_rezult = new System.Windows.Forms.Button();
            this.lba_pm = new System.Windows.Forms.Label();
            this.lba_tm = new System.Windows.Forms.Label();
            this.lb_PM = new System.Windows.Forms.Label();
            this.lb_TM = new System.Windows.Forms.Label();
            this.lb_CodeError = new System.Windows.Forms.Label();
            this.labelCoper = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_TypePrj
            // 
            this.lb_TypePrj.AutoSize = true;
            this.lb_TypePrj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TypePrj.Location = new System.Drawing.Point(13, 22);
            this.lb_TypePrj.Name = "lb_TypePrj";
            this.lb_TypePrj.Size = new System.Drawing.Size(141, 13);
            this.lb_TypePrj.TabIndex = 0;
            this.lb_TypePrj.Text = "Выберите тип проекта";
            // 
            // cb_TypePrj
            // 
            this.cb_TypePrj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TypePrj.FormattingEnabled = true;
            this.cb_TypePrj.Items.AddRange(new object[] {
            "Распространенный",
            "Полунезависимый",
            "Встроенный"});
            this.cb_TypePrj.Location = new System.Drawing.Point(16, 53);
            this.cb_TypePrj.Name = "cb_TypePrj";
            this.cb_TypePrj.Size = new System.Drawing.Size(170, 21);
            this.cb_TypePrj.TabIndex = 1;
            this.cb_TypePrj.SelectedIndexChanged += new System.EventHandler(this.cb_TypePrj_SelectedIndexChanged);
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(16, 91);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(19, 13);
            this.lb_a.TabIndex = 2;
            this.lb_a.Text = "a=";
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(16, 120);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(19, 13);
            this.lb_b.TabIndex = 3;
            this.lb_b.Text = "b=";
            // 
            // lb_d
            // 
            this.lb_d.AutoSize = true;
            this.lb_d.Location = new System.Drawing.Point(101, 120);
            this.lb_d.Name = "lb_d";
            this.lb_d.Size = new System.Drawing.Size(19, 13);
            this.lb_d.TabIndex = 5;
            this.lb_d.Text = "d=";
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(101, 91);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(19, 13);
            this.lb_c.TabIndex = 4;
            this.lb_c.Text = "c=";
            // 
            // lba_d
            // 
            this.lba_d.AutoSize = true;
            this.lba_d.Location = new System.Drawing.Point(132, 120);
            this.lba_d.Name = "lba_d";
            this.lba_d.Size = new System.Drawing.Size(28, 13);
            this.lba_d.TabIndex = 9;
            this.lba_d.Text = "0,38";
            this.lba_d.Click += new System.EventHandler(this.lba_d_Click);
            // 
            // lba_c
            // 
            this.lba_c.AutoSize = true;
            this.lba_c.Location = new System.Drawing.Point(132, 91);
            this.lba_c.Name = "lba_c";
            this.lba_c.Size = new System.Drawing.Size(22, 13);
            this.lba_c.TabIndex = 8;
            this.lba_c.Text = "2,5";
            // 
            // lba_b
            // 
            this.lba_b.AutoSize = true;
            this.lba_b.Location = new System.Drawing.Point(47, 120);
            this.lba_b.Name = "lba_b";
            this.lba_b.Size = new System.Drawing.Size(28, 13);
            this.lba_b.TabIndex = 7;
            this.lba_b.Text = "1,05";
            // 
            // lba_a
            // 
            this.lba_a.AutoSize = true;
            this.lba_a.Location = new System.Drawing.Point(47, 91);
            this.lba_a.Name = "lba_a";
            this.lba_a.Size = new System.Drawing.Size(22, 13);
            this.lba_a.TabIndex = 6;
            this.lba_a.Text = "2,4";
            // 
            // lb_razmCodaEnt
            // 
            this.lb_razmCodaEnt.AutoSize = true;
            this.lb_razmCodaEnt.Location = new System.Drawing.Point(10, 166);
            this.lb_razmCodaEnt.MaximumSize = new System.Drawing.Size(100, 0);
            this.lb_razmCodaEnt.Name = "lb_razmCodaEnt";
            this.lb_razmCodaEnt.Size = new System.Drawing.Size(100, 39);
            this.lb_razmCodaEnt.TabIndex = 10;
            this.lb_razmCodaEnt.Text = "Введите количество строк кода (тыс.)";
            this.lb_razmCodaEnt.Click += new System.EventHandler(this.label10_Click);
            // 
            // tb_razmerCoda
            // 
            this.tb_razmerCoda.Location = new System.Drawing.Point(116, 182);
            this.tb_razmerCoda.MaxLength = 9;
            this.tb_razmerCoda.Name = "tb_razmerCoda";
            this.tb_razmerCoda.Size = new System.Drawing.Size(130, 20);
            this.tb_razmerCoda.TabIndex = 11;
            this.tb_razmerCoda.TextChanged += new System.EventHandler(this.tb_razmerCoda_TextChanged);
            this.tb_razmerCoda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_razmerCoda_KeyPress);
            // 
            // lb_rezult
            // 
            this.lb_rezult.AutoSize = true;
            this.lb_rezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_rezult.Location = new System.Drawing.Point(280, 22);
            this.lb_rezult.Name = "lb_rezult";
            this.lb_rezult.Size = new System.Drawing.Size(68, 13);
            this.lb_rezult.TabIndex = 13;
            this.lb_rezult.Text = "Результат";
            // 
            // btn_rezult
            // 
            this.btn_rezult.Location = new System.Drawing.Point(283, 40);
            this.btn_rezult.Name = "btn_rezult";
            this.btn_rezult.Size = new System.Drawing.Size(75, 54);
            this.btn_rezult.TabIndex = 14;
            this.btn_rezult.Text = "Получить результат";
            this.btn_rezult.UseVisualStyleBackColor = true;
            this.btn_rezult.Click += new System.EventHandler(this.btn_rezult_Click);
            // 
            // lba_pm
            // 
            this.lba_pm.AutoSize = true;
            this.lba_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lba_pm.Location = new System.Drawing.Point(416, 61);
            this.lba_pm.Name = "lba_pm";
            this.lba_pm.Size = new System.Drawing.Size(11, 13);
            this.lba_pm.TabIndex = 15;
            this.lba_pm.Text = "-";
            this.lba_pm.Click += new System.EventHandler(this.label13_Click);
            // 
            // lba_tm
            // 
            this.lba_tm.AutoSize = true;
            this.lba_tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lba_tm.Location = new System.Drawing.Point(416, 118);
            this.lba_tm.Name = "lba_tm";
            this.lba_tm.Size = new System.Drawing.Size(11, 13);
            this.lba_tm.TabIndex = 16;
            this.lba_tm.Text = "-";
            this.lba_tm.Click += new System.EventHandler(this.lba_tm_Click);
            // 
            // lb_PM
            // 
            this.lb_PM.AutoSize = true;
            this.lb_PM.Location = new System.Drawing.Point(376, 35);
            this.lb_PM.Name = "lb_PM";
            this.lb_PM.Size = new System.Drawing.Size(175, 39);
            this.lb_PM.TabIndex = 17;
            this.lb_PM.Text = "Трудоемкость проекта (чел/мес)\r\n\r\nPM =\r\n";
            // 
            // lb_TM
            // 
            this.lb_TM.AutoSize = true;
            this.lb_TM.Location = new System.Drawing.Point(376, 91);
            this.lb_TM.Name = "lb_TM";
            this.lb_TM.Size = new System.Drawing.Size(172, 52);
            this.lb_TM.TabIndex = 18;
            this.lb_TM.Text = "Время разработки проекта(мес)\r\n\r\nTM =\r\n\r\n";
            this.lb_TM.Click += new System.EventHandler(this.lb_TM_Click);
            // 
            // lb_CodeError
            // 
            this.lb_CodeError.AutoSize = true;
            this.lb_CodeError.ForeColor = System.Drawing.Color.Red;
            this.lb_CodeError.Location = new System.Drawing.Point(136, 166);
            this.lb_CodeError.Name = "lb_CodeError";
            this.lb_CodeError.Size = new System.Drawing.Size(110, 13);
            this.lb_CodeError.TabIndex = 19;
            this.lb_CodeError.Text = "Неверное значение!";
            this.lb_CodeError.Visible = false;
            // 
            // labelCoper
            // 
            this.labelCoper.AutoSize = true;
            this.labelCoper.Location = new System.Drawing.Point(224, 260);
            this.labelCoper.Name = "labelCoper";
            this.labelCoper.Size = new System.Drawing.Size(94, 13);
            this.labelCoper.TabIndex = 20;
            this.labelCoper.Text = "© Khromova 2021";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(485, 250);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Назад";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(144, 205);
            this.label6.MaximumSize = new System.Drawing.Size(125, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 26);
            this.label6.TabIndex = 273;
            this.label6.Text = "Вводите значение через точку.";
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 282);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lba_tm);
            this.Controls.Add(this.lba_pm);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.labelCoper);
            this.Controls.Add(this.lb_CodeError);
            this.Controls.Add(this.lb_TM);
            this.Controls.Add(this.lb_PM);
            this.Controls.Add(this.btn_rezult);
            this.Controls.Add(this.lb_rezult);
            this.Controls.Add(this.tb_razmerCoda);
            this.Controls.Add(this.lb_razmCodaEnt);
            this.Controls.Add(this.lba_d);
            this.Controls.Add(this.lba_c);
            this.Controls.Add(this.lba_b);
            this.Controls.Add(this.lba_a);
            this.Controls.Add(this.lb_d);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.lb_b);
            this.Controls.Add(this.lb_a);
            this.Controls.Add(this.cb_TypePrj);
            this.Controls.Add(this.lb_TypePrj);
            this.Name = "Basic";
            this.Text = "Базовый уровень";
            this.Load += new System.EventHandler(this.Basic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TypePrj;
        private System.Windows.Forms.ComboBox cb_TypePrj;
        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.Label lb_d;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.Label lba_d;
        private System.Windows.Forms.Label lba_c;
        private System.Windows.Forms.Label lba_b;
        private System.Windows.Forms.Label lba_a;
        private System.Windows.Forms.Label lb_razmCodaEnt;
        private System.Windows.Forms.TextBox tb_razmerCoda;
        private System.Windows.Forms.Label lb_rezult;
        private System.Windows.Forms.Button btn_rezult;
        private System.Windows.Forms.Label lba_pm;
        private System.Windows.Forms.Label lba_tm;
        private System.Windows.Forms.Label lb_PM;
        private System.Windows.Forms.Label lb_TM;
        private System.Windows.Forms.Label lb_CodeError;
        private System.Windows.Forms.Label labelCoper;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label6;
    }
}
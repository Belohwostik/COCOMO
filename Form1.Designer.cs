
namespace COCOMOv01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCocomo1 = new System.Windows.Forms.Button();
            this.buttonCocomo2 = new System.Windows.Forms.Button();
            this.buttonCocomo32 = new System.Windows.Forms.Button();
            this.buttonCocomo31 = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSpravka = new System.Windows.Forms.Button();
            this.labelCocomo12 = new System.Windows.Forms.Label();
            this.labelCocomo3 = new System.Windows.Forms.Label();
            this.labelCoper = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCocomo1
            // 
            this.buttonCocomo1.Location = new System.Drawing.Point(12, 47);
            this.buttonCocomo1.Name = "buttonCocomo1";
            this.buttonCocomo1.Size = new System.Drawing.Size(164, 44);
            this.buttonCocomo1.TabIndex = 0;
            this.buttonCocomo1.Text = "Базовый уровень";
            this.buttonCocomo1.UseVisualStyleBackColor = true;
            this.buttonCocomo1.Click += new System.EventHandler(this.buttonCocomo1_Click);
            // 
            // buttonCocomo2
            // 
            this.buttonCocomo2.Location = new System.Drawing.Point(12, 106);
            this.buttonCocomo2.Name = "buttonCocomo2";
            this.buttonCocomo2.Size = new System.Drawing.Size(164, 44);
            this.buttonCocomo2.TabIndex = 1;
            this.buttonCocomo2.Text = "Промежуточный уровень";
            this.buttonCocomo2.UseVisualStyleBackColor = true;
            this.buttonCocomo2.Click += new System.EventHandler(this.buttonCocomo2_Click);
            // 
            // buttonCocomo32
            // 
            this.buttonCocomo32.Location = new System.Drawing.Point(264, 103);
            this.buttonCocomo32.Name = "buttonCocomo32";
            this.buttonCocomo32.Size = new System.Drawing.Size(163, 47);
            this.buttonCocomo32.TabIndex = 3;
            this.buttonCocomo32.Text = "Детальная оценка";
            this.buttonCocomo32.UseVisualStyleBackColor = true;
            this.buttonCocomo32.Click += new System.EventHandler(this.buttonCocomo32_Click);
            // 
            // buttonCocomo31
            // 
            this.buttonCocomo31.Location = new System.Drawing.Point(264, 44);
            this.buttonCocomo31.Name = "buttonCocomo31";
            this.buttonCocomo31.Size = new System.Drawing.Size(164, 47);
            this.buttonCocomo31.TabIndex = 2;
            this.buttonCocomo31.Text = "Предварительная оценка";
            this.buttonCocomo31.UseVisualStyleBackColor = true;
            this.buttonCocomo31.Click += new System.EventHandler(this.buttonCocomo31_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(12, 282);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(116, 33);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "Об авторе";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSpravka
            // 
            this.buttonSpravka.Location = new System.Drawing.Point(312, 282);
            this.buttonSpravka.Name = "buttonSpravka";
            this.buttonSpravka.Size = new System.Drawing.Size(116, 33);
            this.buttonSpravka.TabIndex = 5;
            this.buttonSpravka.Text = "Справка";
            this.buttonSpravka.UseVisualStyleBackColor = true;
            this.buttonSpravka.Click += new System.EventHandler(this.buttonSpravka_Click);
            // 
            // labelCocomo12
            // 
            this.labelCocomo12.AutoSize = true;
            this.labelCocomo12.Location = new System.Drawing.Point(13, 13);
            this.labelCocomo12.Name = "labelCocomo12";
            this.labelCocomo12.Size = new System.Drawing.Size(54, 13);
            this.labelCocomo12.TabIndex = 6;
            this.labelCocomo12.Text = "COCOMO";
            // 
            // labelCocomo3
            // 
            this.labelCocomo3.AutoSize = true;
            this.labelCocomo3.Location = new System.Drawing.Point(261, 13);
            this.labelCocomo3.Name = "labelCocomo3";
            this.labelCocomo3.Size = new System.Drawing.Size(63, 13);
            this.labelCocomo3.TabIndex = 7;
            this.labelCocomo3.Text = "COCOMO II";
            // 
            // labelCoper
            // 
            this.labelCoper.AutoSize = true;
            this.labelCoper.Location = new System.Drawing.Point(169, 302);
            this.labelCoper.Name = "labelCoper";
            this.labelCoper.Size = new System.Drawing.Size(94, 13);
            this.labelCoper.TabIndex = 8;
            this.labelCoper.Text = "© Khromova 2021";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Лицензия";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCoper);
            this.Controls.Add(this.labelCocomo3);
            this.Controls.Add(this.labelCocomo12);
            this.Controls.Add(this.buttonSpravka);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonCocomo32);
            this.Controls.Add(this.buttonCocomo31);
            this.Controls.Add(this.buttonCocomo2);
            this.Controls.Add(this.buttonCocomo1);
            this.Name = "Form1";
            this.Text = "Калькулятор COCOMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCocomo1;
        private System.Windows.Forms.Button buttonCocomo2;
        private System.Windows.Forms.Button buttonCocomo32;
        private System.Windows.Forms.Button buttonCocomo31;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSpravka;
        private System.Windows.Forms.Label labelCocomo12;
        private System.Windows.Forms.Label labelCocomo3;
        private System.Windows.Forms.Label labelCoper;
        private System.Windows.Forms.Button button1;
    }
}


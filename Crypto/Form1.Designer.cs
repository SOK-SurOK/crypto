﻿namespace Crypto
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
            this.buttonCrypto = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonDecrypto = new System.Windows.Forms.Button();
            this.comboBoxVibor = new System.Windows.Forms.ComboBox();
            this.labelIN = new System.Windows.Forms.Label();
            this.groupBoxVvod = new System.Windows.Forms.GroupBox();
            this.labelOUT = new System.Windows.Forms.Label();
            this.groupBoxVibor = new System.Windows.Forms.GroupBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBoxVvod.SuspendLayout();
            this.groupBoxVibor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrypto
            // 
            this.buttonCrypto.Location = new System.Drawing.Point(33, 73);
            this.buttonCrypto.Name = "buttonCrypto";
            this.buttonCrypto.Size = new System.Drawing.Size(219, 31);
            this.buttonCrypto.TabIndex = 0;
            this.buttonCrypto.Text = "Кодировать";
            this.buttonCrypto.UseVisualStyleBackColor = true;
            this.buttonCrypto.Click += new System.EventHandler(this.ButtonCrypto_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(144, 39);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(219, 22);
            this.textBoxIn.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(143, 188);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(220, 22);
            this.textBoxOut.TabIndex = 2;
            // 
            // buttonDecrypto
            // 
            this.buttonDecrypto.Location = new System.Drawing.Point(33, 123);
            this.buttonDecrypto.Name = "buttonDecrypto";
            this.buttonDecrypto.Size = new System.Drawing.Size(219, 36);
            this.buttonDecrypto.TabIndex = 3;
            this.buttonDecrypto.Text = "Раскодировать";
            this.buttonDecrypto.UseVisualStyleBackColor = true;
            this.buttonDecrypto.Click += new System.EventHandler(this.ButtonDecrypto_Click);
            // 
            // comboBoxVibor
            // 
            this.comboBoxVibor.FormattingEnabled = true;
            this.comboBoxVibor.Location = new System.Drawing.Point(33, 31);
            this.comboBoxVibor.Name = "comboBoxVibor";
            this.comboBoxVibor.Size = new System.Drawing.Size(219, 24);
            this.comboBoxVibor.TabIndex = 4;
            this.comboBoxVibor.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // labelIN
            // 
            this.labelIN.AutoSize = true;
            this.labelIN.Location = new System.Drawing.Point(6, 39);
            this.labelIN.Name = "labelIN";
            this.labelIN.Size = new System.Drawing.Size(54, 17);
            this.labelIN.TabIndex = 5;
            this.labelIN.Text = "Ввести";
            // 
            // groupBoxVvod
            // 
            this.groupBoxVvod.Controls.Add(this.textBoxKey);
            this.groupBoxVvod.Controls.Add(this.textBoxOut);
            this.groupBoxVvod.Controls.Add(this.labelKey);
            this.groupBoxVvod.Controls.Add(this.textBoxIn);
            this.groupBoxVvod.Controls.Add(this.labelOUT);
            this.groupBoxVvod.Controls.Add(this.labelIN);
            this.groupBoxVvod.Location = new System.Drawing.Point(367, 40);
            this.groupBoxVvod.Name = "groupBoxVvod";
            this.groupBoxVvod.Size = new System.Drawing.Size(369, 216);
            this.groupBoxVvod.TabIndex = 6;
            this.groupBoxVvod.TabStop = false;
            this.groupBoxVvod.Text = "В 16 виде";
            // 
            // labelOUT
            // 
            this.labelOUT.AutoSize = true;
            this.labelOUT.Location = new System.Drawing.Point(6, 188);
            this.labelOUT.Name = "labelOUT";
            this.labelOUT.Size = new System.Drawing.Size(49, 17);
            this.labelOUT.TabIndex = 5;
            this.labelOUT.Text = "Выход";
            // 
            // groupBoxVibor
            // 
            this.groupBoxVibor.Controls.Add(this.buttonCrypto);
            this.groupBoxVibor.Controls.Add(this.buttonDecrypto);
            this.groupBoxVibor.Controls.Add(this.comboBoxVibor);
            this.groupBoxVibor.Location = new System.Drawing.Point(12, 40);
            this.groupBoxVibor.Name = "groupBoxVibor";
            this.groupBoxVibor.Size = new System.Drawing.Size(315, 179);
            this.groupBoxVibor.TabIndex = 7;
            this.groupBoxVibor.TabStop = false;
            this.groupBoxVibor.Text = "Выберете";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(7, 113);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(91, 17);
            this.labelKey.TabIndex = 5;
            this.labelKey.Text = "Ввести ключ";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(144, 113);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(220, 22);
            this.textBoxKey.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 449);
            this.Controls.Add(this.groupBoxVibor);
            this.Controls.Add(this.groupBoxVvod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxVvod.ResumeLayout(false);
            this.groupBoxVvod.PerformLayout();
            this.groupBoxVibor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrypto;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonDecrypto;
        private System.Windows.Forms.ComboBox comboBoxVibor;
        private System.Windows.Forms.Label labelIN;
        private System.Windows.Forms.GroupBox groupBoxVvod;
        private System.Windows.Forms.Label labelOUT;
        private System.Windows.Forms.GroupBox groupBoxVibor;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
    }
}


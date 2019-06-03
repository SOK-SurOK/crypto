namespace Crypto
{
    partial class FormMagma
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
            this.groupBoxVvod = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.labelOUT = new System.Windows.Forms.Label();
            this.labelIN = new System.Windows.Forms.Label();
            this.groupBoxVibor = new System.Windows.Forms.GroupBox();
            this.buttonCrypto = new System.Windows.Forms.Button();
            this.buttonDecrypto = new System.Windows.Forms.Button();
            this.groupBoxVvod.SuspendLayout();
            this.groupBoxVibor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVvod
            // 
            this.groupBoxVvod.Controls.Add(this.textBoxKey);
            this.groupBoxVvod.Controls.Add(this.textBoxOut);
            this.groupBoxVvod.Controls.Add(this.labelKey);
            this.groupBoxVvod.Controls.Add(this.textBoxIn);
            this.groupBoxVvod.Controls.Add(this.labelOUT);
            this.groupBoxVvod.Controls.Add(this.labelIN);
            this.groupBoxVvod.Location = new System.Drawing.Point(30, 222);
            this.groupBoxVvod.Name = "groupBoxVvod";
            this.groupBoxVvod.Size = new System.Drawing.Size(737, 216);
            this.groupBoxVvod.TabIndex = 7;
            this.groupBoxVvod.TabStop = false;
            this.groupBoxVvod.Text = "В 16 виде";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(144, 113);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(587, 22);
            this.textBoxKey.TabIndex = 2;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(143, 188);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(588, 22);
            this.textBoxOut.TabIndex = 2;
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
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(144, 39);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(587, 22);
            this.textBoxIn.TabIndex = 1;
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
            // labelIN
            // 
            this.labelIN.AutoSize = true;
            this.labelIN.Location = new System.Drawing.Point(6, 39);
            this.labelIN.Name = "labelIN";
            this.labelIN.Size = new System.Drawing.Size(54, 17);
            this.labelIN.TabIndex = 5;
            this.labelIN.Text = "Ввести";
            // 
            // groupBoxVibor
            // 
            this.groupBoxVibor.Controls.Add(this.buttonCrypto);
            this.groupBoxVibor.Controls.Add(this.buttonDecrypto);
            this.groupBoxVibor.Location = new System.Drawing.Point(30, 9);
            this.groupBoxVibor.Name = "groupBoxVibor";
            this.groupBoxVibor.Size = new System.Drawing.Size(737, 207);
            this.groupBoxVibor.TabIndex = 8;
            this.groupBoxVibor.TabStop = false;
            this.groupBoxVibor.Text = "Выберете";
            // 
            // buttonCrypto
            // 
            this.buttonCrypto.Location = new System.Drawing.Point(81, 92);
            this.buttonCrypto.Name = "buttonCrypto";
            this.buttonCrypto.Size = new System.Drawing.Size(219, 36);
            this.buttonCrypto.TabIndex = 0;
            this.buttonCrypto.Text = "Кодировать";
            this.buttonCrypto.UseVisualStyleBackColor = true;
            this.buttonCrypto.Click += new System.EventHandler(this.ButtonCrypto_Click);
            // 
            // buttonDecrypto
            // 
            this.buttonDecrypto.Location = new System.Drawing.Point(424, 92);
            this.buttonDecrypto.Name = "buttonDecrypto";
            this.buttonDecrypto.Size = new System.Drawing.Size(219, 36);
            this.buttonDecrypto.TabIndex = 3;
            this.buttonDecrypto.Text = "Раскодировать";
            this.buttonDecrypto.UseVisualStyleBackColor = true;
            this.buttonDecrypto.Click += new System.EventHandler(this.ButtonDecrypto_Click);
            // 
            // FormMagma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxVibor);
            this.Controls.Add(this.groupBoxVvod);
            this.Name = "FormMagma";
            this.Text = "FormMagma";
            this.groupBoxVvod.ResumeLayout(false);
            this.groupBoxVvod.PerformLayout();
            this.groupBoxVibor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVvod;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label labelOUT;
        private System.Windows.Forms.Label labelIN;
        private System.Windows.Forms.GroupBox groupBoxVibor;
        private System.Windows.Forms.Button buttonCrypto;
        private System.Windows.Forms.Button buttonDecrypto;
    }
}
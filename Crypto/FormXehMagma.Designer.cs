namespace Crypto
{
    partial class FormXehMagma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonEn = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxKey);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.buttonEn);
            this.groupBox1.Controls.Add(this.buttonR);
            this.groupBox1.Location = new System.Drawing.Point(94, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод в 16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Значение";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(134, 156);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(476, 22);
            this.textBoxKey.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(134, 60);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(476, 22);
            this.textBox.TabIndex = 1;
            // 
            // buttonEn
            // 
            this.buttonEn.Location = new System.Drawing.Point(413, 228);
            this.buttonEn.Name = "buttonEn";
            this.buttonEn.Size = new System.Drawing.Size(110, 26);
            this.buttonEn.TabIndex = 0;
            this.buttonEn.Text = "Захэшировать";
            this.buttonEn.UseVisualStyleBackColor = true;
            this.buttonEn.Click += new System.EventHandler(this.ButtonEn_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(67, 228);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 26);
            this.buttonR.TabIndex = 0;
            this.buttonR.Text = "Random";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.ButtonR_Click);
            // 
            // FormXehMagma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormXehMagma";
            this.Text = "XehMagmaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonEn;
        private System.Windows.Forms.Button buttonR;
    }
}
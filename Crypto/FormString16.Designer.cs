namespace Crypto
{
    partial class FormString16
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
            this.groupBoxHexString = new System.Windows.Forms.GroupBox();
            this.buttonTextS = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxHexString.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHexString
            // 
            this.groupBoxHexString.Controls.Add(this.label1);
            this.groupBoxHexString.Controls.Add(this.buttonTextS);
            this.groupBoxHexString.Controls.Add(this.buttonText);
            this.groupBoxHexString.Controls.Add(this.textBoxText);
            this.groupBoxHexString.Location = new System.Drawing.Point(199, 122);
            this.groupBoxHexString.Name = "groupBoxHexString";
            this.groupBoxHexString.Size = new System.Drawing.Size(402, 251);
            this.groupBoxHexString.TabIndex = 10;
            this.groupBoxHexString.TabStop = false;
            this.groupBoxHexString.Text = "Перевести текст 16 - string";
            // 
            // buttonTextS
            // 
            this.buttonTextS.Location = new System.Drawing.Point(232, 73);
            this.buttonTextS.Name = "buttonTextS";
            this.buttonTextS.Size = new System.Drawing.Size(75, 31);
            this.buttonTextS.TabIndex = 1;
            this.buttonTextS.Text = "В String";
            this.buttonTextS.UseVisualStyleBackColor = true;
            this.buttonTextS.Click += new System.EventHandler(this.ButtonTextS_Click);
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(107, 73);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(75, 31);
            this.buttonText.TabIndex = 1;
            this.buttonText.Text = "В 16";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.ButtonText_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(6, 148);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(390, 22);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SizeOfString";
            // 
            // String16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxHexString);
            this.Name = "String16";
            this.Text = "String16";
            this.groupBoxHexString.ResumeLayout(false);
            this.groupBoxHexString.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHexString;
        private System.Windows.Forms.Button buttonTextS;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
    }
}
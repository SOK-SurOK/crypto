namespace Crypto
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxVibor = new System.Windows.Forms.ComboBox();
            this.groupBoxVibor = new System.Windows.Forms.GroupBox();
            this.groupBoxVibor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(33, 73);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(219, 31);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // comboBoxVibor
            // 
            this.comboBoxVibor.FormattingEnabled = true;
            this.comboBoxVibor.Location = new System.Drawing.Point(33, 31);
            this.comboBoxVibor.Name = "comboBoxVibor";
            this.comboBoxVibor.Size = new System.Drawing.Size(219, 24);
            this.comboBoxVibor.TabIndex = 4;
            // 
            // groupBoxVibor
            // 
            this.groupBoxVibor.Controls.Add(this.buttonOpen);
            this.groupBoxVibor.Controls.Add(this.comboBoxVibor);
            this.groupBoxVibor.Location = new System.Drawing.Point(263, 117);
            this.groupBoxVibor.Name = "groupBoxVibor";
            this.groupBoxVibor.Size = new System.Drawing.Size(290, 195);
            this.groupBoxVibor.TabIndex = 7;
            this.groupBoxVibor.TabStop = false;
            this.groupBoxVibor.Text = "Выберете";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 449);
            this.Controls.Add(this.groupBoxVibor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxVibor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxVibor;
        private System.Windows.Forms.GroupBox groupBoxVibor;
    }
}


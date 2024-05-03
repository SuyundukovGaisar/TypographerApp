namespace TypographerApp
{
    partial class MainForm
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
            this.StarttextBox = new System.Windows.Forms.TextBox();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Startlabel = new System.Windows.Forms.Label();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StarttextBox
            // 
            this.StarttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StarttextBox.Location = new System.Drawing.Point(13, 42);
            this.StarttextBox.Multiline = true;
            this.StarttextBox.Name = "StarttextBox";
            this.StarttextBox.Size = new System.Drawing.Size(394, 430);
            this.StarttextBox.TabIndex = 0;
            this.StarttextBox.TextChanged += new System.EventHandler(this.StarttextBox_TextChanged);
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ResulttextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResulttextBox.Location = new System.Drawing.Point(430, 42);
            this.ResulttextBox.Multiline = true;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.ReadOnly = true;
            this.ResulttextBox.Size = new System.Drawing.Size(394, 430);
            this.ResulttextBox.TabIndex = 1;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(324, 13);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(83, 23);
            this.Deletebutton.TabIndex = 2;
            this.Deletebutton.Text = "Очистить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Startlabel
            // 
            this.Startlabel.AutoSize = true;
            this.Startlabel.Location = new System.Drawing.Point(13, 20);
            this.Startlabel.Name = "Startlabel";
            this.Startlabel.Size = new System.Drawing.Size(136, 16);
            this.Startlabel.TabIndex = 3;
            this.Startlabel.Text = "Изначальный текст";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(427, 20);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(77, 16);
            this.Resultlabel.TabIndex = 4;
            this.Resultlabel.Text = "Результат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(833, 484);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.Startlabel);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.StarttextBox);
            this.Name = "MainForm";
            this.Text = "Типограф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StarttextBox;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label Startlabel;
        private System.Windows.Forms.Label Resultlabel;
    }
}


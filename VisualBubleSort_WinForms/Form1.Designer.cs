namespace VisualBubleSort_WinForms
{
    partial class Form
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.byStep = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(497, 13);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "Сортувати";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 15);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(479, 20);
            this.textBox.TabIndex = 1;
            // 
            // byStep
            // 
            this.byStep.AutoSize = true;
            this.byStep.Location = new System.Drawing.Point(12, 41);
            this.byStep.Name = "byStep";
            this.byStep.Size = new System.Drawing.Size(82, 17);
            this.byStep.TabIndex = 2;
            this.byStep.Text = "Покроково";
            this.byStep.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(100, 37);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Зупинити";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 116);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.byStep);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.sortBtn);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортування бульбашкою (Denis Kotenko 315 PI)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox byStep;
        private System.Windows.Forms.Button buttonStop;
    }
}


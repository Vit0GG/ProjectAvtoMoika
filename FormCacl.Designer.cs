namespace ProjectAvtoMoika
{
    partial class FormCacl
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
            this.Uslugi = new System.Windows.Forms.CheckedListBox();
            this.Schet = new System.Windows.Forms.Button();
            this.TipsKuzov = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Uslugi
            // 
            this.Uslugi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Uslugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Uslugi.FormattingEnabled = true;
            this.Uslugi.Location = new System.Drawing.Point(41, 177);
            this.Uslugi.Name = "Uslugi";
            this.Uslugi.Size = new System.Drawing.Size(479, 106);
            this.Uslugi.TabIndex = 1;
            // 
            // Schet
            // 
            this.Schet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.Schet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Schet.FlatAppearance.BorderSize = 0;
            this.Schet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Schet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Schet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Schet.ForeColor = System.Drawing.Color.White;
            this.Schet.Location = new System.Drawing.Point(41, 299);
            this.Schet.Name = "Schet";
            this.Schet.Size = new System.Drawing.Size(114, 61);
            this.Schet.TabIndex = 4;
            this.Schet.Text = "Вычислить";
            this.Schet.UseVisualStyleBackColor = false;
            this.Schet.Click += new System.EventHandler(this.Schet_Click);
            // 
            // TipsKuzov
            // 
            this.TipsKuzov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipsKuzov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipsKuzov.FormattingEnabled = true;
            this.TipsKuzov.Location = new System.Drawing.Point(41, 70);
            this.TipsKuzov.Name = "TipsKuzov";
            this.TipsKuzov.Size = new System.Drawing.Size(244, 28);
            this.TipsKuzov.TabIndex = 6;
            this.TipsKuzov.Enter += new System.EventHandler(this.TipsKuzov_Enter);
            this.TipsKuzov.Leave += new System.EventHandler(this.TipsKuzov_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Калькулятор стоимости услуг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите услугу (услуги)";
            // 
            // FormCacl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipsKuzov);
            this.Controls.Add(this.Schet);
            this.Controls.Add(this.Uslugi);
            this.Name = "FormCacl";
            this.Text = "FormCacl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox Uslugi;
        private System.Windows.Forms.Button Schet;
        private System.Windows.Forms.ComboBox TipsKuzov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace ProjectAvtoMoika
{
    partial class AdminTable
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddUslugi = new System.Windows.Forms.Button();
            this.AddKuzova = new System.Windows.Forms.Button();
            this.TextCostUsluga = new System.Windows.Forms.TextBox();
            this.TextTimeUsluga = new System.Windows.Forms.TextBox();
            this.TextUsluga = new System.Windows.Forms.TextBox();
            this.TextTipKuzov = new System.Windows.Forms.TextBox();
            this.TextXCost = new System.Windows.Forms.TextBox();
            this.TextXTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавить кузов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Добавить Услугу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(230, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Админ панель";
            // 
            // AddUslugi
            // 
            this.AddUslugi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.AddUslugi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUslugi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddUslugi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AddUslugi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddUslugi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUslugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUslugi.ForeColor = System.Drawing.Color.White;
            this.AddUslugi.Location = new System.Drawing.Point(100, 306);
            this.AddUslugi.Name = "AddUslugi";
            this.AddUslugi.Size = new System.Drawing.Size(90, 33);
            this.AddUslugi.TabIndex = 5;
            this.AddUslugi.Text = "Добавить";
            this.AddUslugi.UseVisualStyleBackColor = false;
            this.AddUslugi.Click += new System.EventHandler(this.AddUslugi_Click);
            // 
            // AddKuzova
            // 
            this.AddKuzova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.AddKuzova.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddKuzova.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AddKuzova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddKuzova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKuzova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddKuzova.ForeColor = System.Drawing.Color.White;
            this.AddKuzova.Location = new System.Drawing.Point(443, 306);
            this.AddKuzova.Name = "AddKuzova";
            this.AddKuzova.Size = new System.Drawing.Size(86, 33);
            this.AddKuzova.TabIndex = 6;
            this.AddKuzova.Text = "Добавить";
            this.AddKuzova.UseVisualStyleBackColor = false;
            this.AddKuzova.Click += new System.EventHandler(this.AddKuzova_Click);
            // 
            // TextCostUsluga
            // 
            this.TextCostUsluga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextCostUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextCostUsluga.Location = new System.Drawing.Point(22, 184);
            this.TextCostUsluga.Multiline = true;
            this.TextCostUsluga.Name = "TextCostUsluga";
            this.TextCostUsluga.Size = new System.Drawing.Size(267, 27);
            this.TextCostUsluga.TabIndex = 7;
            this.TextCostUsluga.Enter += new System.EventHandler(this.TextCostUsluga_Enter);
            this.TextCostUsluga.Leave += new System.EventHandler(this.TextCostUsluga_Leave);
            // 
            // TextTimeUsluga
            // 
            this.TextTimeUsluga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextTimeUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTimeUsluga.Location = new System.Drawing.Point(22, 237);
            this.TextTimeUsluga.Multiline = true;
            this.TextTimeUsluga.Name = "TextTimeUsluga";
            this.TextTimeUsluga.Size = new System.Drawing.Size(267, 27);
            this.TextTimeUsluga.TabIndex = 8;
            this.TextTimeUsluga.Enter += new System.EventHandler(this.TextTimeUsluga_Enter);
            this.TextTimeUsluga.Leave += new System.EventHandler(this.TextTimeUsluga_Leave);
            // 
            // TextUsluga
            // 
            this.TextUsluga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextUsluga.Location = new System.Drawing.Point(22, 136);
            this.TextUsluga.Multiline = true;
            this.TextUsluga.Name = "TextUsluga";
            this.TextUsluga.Size = new System.Drawing.Size(267, 25);
            this.TextUsluga.TabIndex = 9;
            this.TextUsluga.Enter += new System.EventHandler(this.TextUsluga_Enter);
            this.TextUsluga.Leave += new System.EventHandler(this.TextUsluga_Leave);
            // 
            // TextTipKuzov
            // 
            this.TextTipKuzov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTipKuzov.Location = new System.Drawing.Point(348, 136);
            this.TextTipKuzov.Multiline = true;
            this.TextTipKuzov.Name = "TextTipKuzov";
            this.TextTipKuzov.Size = new System.Drawing.Size(263, 25);
            this.TextTipKuzov.TabIndex = 10;
            this.TextTipKuzov.Enter += new System.EventHandler(this.TextTipKuzov_Enter);
            this.TextTipKuzov.Leave += new System.EventHandler(this.TextTipKuzov_Leave);
            // 
            // TextXCost
            // 
            this.TextXCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextXCost.Location = new System.Drawing.Point(348, 184);
            this.TextXCost.Multiline = true;
            this.TextXCost.Name = "TextXCost";
            this.TextXCost.Size = new System.Drawing.Size(263, 27);
            this.TextXCost.TabIndex = 11;
            this.TextXCost.Enter += new System.EventHandler(this.TextXCost_Enter);
            this.TextXCost.Leave += new System.EventHandler(this.TextXCost_Leave);
            // 
            // TextXTime
            // 
            this.TextXTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextXTime.Location = new System.Drawing.Point(348, 237);
            this.TextXTime.Multiline = true;
            this.TextXTime.Name = "TextXTime";
            this.TextXTime.Size = new System.Drawing.Size(263, 27);
            this.TextXTime.TabIndex = 12;
            this.TextXTime.Enter += new System.EventHandler(this.TextXTime_Enter);
            this.TextXTime.Leave += new System.EventHandler(this.TextXTime_Leave);
            // 
            // AdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.TextXTime);
            this.Controls.Add(this.TextXCost);
            this.Controls.Add(this.TextTipKuzov);
            this.Controls.Add(this.TextUsluga);
            this.Controls.Add(this.TextTimeUsluga);
            this.Controls.Add(this.TextCostUsluga);
            this.Controls.Add(this.AddKuzova);
            this.Controls.Add(this.AddUslugi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AdminTable";
            this.Text = "AdminTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddUslugi;
        private System.Windows.Forms.Button AddKuzova;
        private System.Windows.Forms.TextBox TextCostUsluga;
        private System.Windows.Forms.TextBox TextTimeUsluga;
        private System.Windows.Forms.TextBox TextUsluga;
        private System.Windows.Forms.TextBox TextTipKuzov;
        private System.Windows.Forms.TextBox TextXCost;
        private System.Windows.Forms.TextBox TextXTime;
    }
}
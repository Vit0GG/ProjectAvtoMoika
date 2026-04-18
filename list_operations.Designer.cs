namespace ProjectAvtoMoika
{
    partial class list_operations
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
            this.label1 = new System.Windows.Forms.Label();
            this.chekedUslugi = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NumsMob = new System.Windows.Forms.TextBox();
            this.Add_List = new System.Windows.Forms.Button();
            this.Kuzova = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавления в лист операций";
            // 
            // chekedUslugi
            // 
            this.chekedUslugi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chekedUslugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chekedUslugi.FormattingEnabled = true;
            this.chekedUslugi.Location = new System.Drawing.Point(52, 189);
            this.chekedUslugi.Name = "chekedUslugi";
            this.chekedUslugi.Size = new System.Drawing.Size(335, 106);
            this.chekedUslugi.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // NumsMob
            // 
            this.NumsMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumsMob.Location = new System.Drawing.Point(51, 76);
            this.NumsMob.Multiline = true;
            this.NumsMob.Name = "NumsMob";
            this.NumsMob.Size = new System.Drawing.Size(193, 44);
            this.NumsMob.TabIndex = 4;
            this.NumsMob.Click += new System.EventHandler(this.NumsMob_Click);
            this.NumsMob.Enter += new System.EventHandler(this.NumsMob_Enter);
            this.NumsMob.Leave += new System.EventHandler(this.NumsMob_Leave);
            // 
            // Add_List
            // 
            this.Add_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.Add_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_List.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Add_List.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Add_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_List.ForeColor = System.Drawing.Color.White;
            this.Add_List.Location = new System.Drawing.Point(52, 340);
            this.Add_List.Name = "Add_List";
            this.Add_List.Size = new System.Drawing.Size(126, 44);
            this.Add_List.TabIndex = 5;
            this.Add_List.Text = "Добавить";
            this.Add_List.UseVisualStyleBackColor = false;
            this.Add_List.Click += new System.EventHandler(this.Add_List_Click);
            // 
            // Kuzova
            // 
            this.Kuzova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kuzova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kuzova.FormattingEnabled = true;
            this.Kuzova.Location = new System.Drawing.Point(52, 126);
            this.Kuzova.Name = "Kuzova";
            this.Kuzova.Size = new System.Drawing.Size(193, 24);
            this.Kuzova.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите услугу(услуги)";
            // 
            // list_operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kuzova);
            this.Controls.Add(this.Add_List);
            this.Controls.Add(this.NumsMob);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chekedUslugi);
            this.Controls.Add(this.label1);
            this.Name = "list_operations";
            this.Text = "list_operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chekedUslugi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox NumsMob;
        private System.Windows.Forms.Button Add_List;
        private System.Windows.Forms.ComboBox Kuzova;
        private System.Windows.Forms.Label label2;
    }
}
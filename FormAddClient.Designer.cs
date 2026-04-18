namespace ProjectAvtoMoika
{
    partial class AddClient
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
            this.LoginField = new System.Windows.Forms.TextBox();
            this.Nums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.NumberMob = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(190, 96);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(277, 52);
            this.LoginField.TabIndex = 0;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // Nums
            // 
            this.Nums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nums.Location = new System.Drawing.Point(190, 252);
            this.Nums.Multiline = true;
            this.Nums.Name = "Nums";
            this.Nums.Size = new System.Drawing.Size(277, 52);
            this.Nums.TabIndex = 7;
            this.Nums.Enter += new System.EventHandler(this.Nums_Enter);
            this.Nums.Leave += new System.EventHandler(this.Nums_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавление клиента";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAdd.Location = new System.Drawing.Point(243, 320);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(159, 59);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberMob
            // 
            this.NumberMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberMob.Location = new System.Drawing.Point(190, 172);
            this.NumberMob.Multiline = true;
            this.NumberMob.Name = "NumberMob";
            this.NumberMob.Size = new System.Drawing.Size(277, 55);
            this.NumberMob.TabIndex = 10;
            this.NumberMob.Enter += new System.EventHandler(this.NumberMob_Enter);
            this.NumberMob.Leave += new System.EventHandler(this.NumberMob_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectAvtoMoika.Properties.Resources.icons8_phone_96;
            this.pictureBox3.Location = new System.Drawing.Point(133, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = global::ProjectAvtoMoika.Properties.Resources._315583_1_file_numbers_icon;
            this.pictureBox2.Location = new System.Drawing.Point(133, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::ProjectAvtoMoika.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(133, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.NumberMob);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nums);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginField);
            this.Name = "AddClient";
            this.Text = "FormAddClient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Nums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox NumberMob;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
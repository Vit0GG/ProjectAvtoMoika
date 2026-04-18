namespace ProjectAvtoMoika
{
    partial class AvtoMoika
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
            this.AddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.Nums = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.AddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddClient.Location = new System.Drawing.Point(290, 342);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(259, 68);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Добавить";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "АвтоМойка";
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(290, 122);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(280, 56);
            this.LoginField.TabIndex = 2;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // Nums
            // 
            this.Nums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nums.Location = new System.Drawing.Point(290, 228);
            this.Nums.Multiline = true;
            this.Nums.Name = "Nums";
            this.Nums.Size = new System.Drawing.Size(280, 56);
            this.Nums.TabIndex = 3;
            this.Nums.TextChanged += new System.EventHandler(this.Nums_TextChanged);
            this.Nums.Enter += new System.EventHandler(this.Nums_Enter);
            this.Nums.Leave += new System.EventHandler(this.Nums_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectAvtoMoika.Properties.Resources._315583_1_file_numbers_icon;
            this.pictureBox2.Location = new System.Drawing.Point(223, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::ProjectAvtoMoika.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(223, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AvtoMoika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Nums);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddClient);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AvtoMoika";
            this.Text = "AvtoMoika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox Nums;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


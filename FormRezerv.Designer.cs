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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.escapeButton = new FontAwesome.Sharp.IconButton();
            this.widebutton = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Calc = new FontAwesome.Sharp.IconButton();
            this.ClientAm = new System.Windows.Forms.Panel();
            this.AddUser = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.ClientAm.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "АвтоМойка";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.escapeButton);
            this.panel1.Controls.Add(this.widebutton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 32;
            this.CloseButton.Location = new System.Drawing.Point(746, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(54, 54);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // escapeButton
            // 
            this.escapeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.escapeButton.FlatAppearance.BorderSize = 0;
            this.escapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.escapeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.escapeButton.IconColor = System.Drawing.Color.White;
            this.escapeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.escapeButton.IconSize = 32;
            this.escapeButton.Location = new System.Drawing.Point(621, 1);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(54, 53);
            this.escapeButton.TabIndex = 11;
            this.escapeButton.UseVisualStyleBackColor = true;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // widebutton
            // 
            this.widebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widebutton.FlatAppearance.BorderSize = 0;
            this.widebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.widebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.widebutton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.widebutton.IconColor = System.Drawing.Color.White;
            this.widebutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.widebutton.IconSize = 32;
            this.widebutton.Location = new System.Drawing.Point(676, 0);
            this.widebutton.Name = "widebutton";
            this.widebutton.Size = new System.Drawing.Size(69, 60);
            this.widebutton.TabIndex = 10;
            this.widebutton.UseVisualStyleBackColor = true;
            this.widebutton.Click += new System.EventHandler(this.widebutton_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 74);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.AdminButton);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ClientAm);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 394);
            this.panel2.TabIndex = 7;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(50, 348);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(117, 34);
            this.AdminButton.TabIndex = 12;
            this.AdminButton.Text = "Админ Панель";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectAvtoMoika.Properties.Resources.icons8_список_64;
            this.pictureBox3.Location = new System.Drawing.Point(4, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(50, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Запись клиента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectAvtoMoika.Properties.Resources._5027823_calculator_coin_dollar_money_icon;
            this.pictureBox2.Location = new System.Drawing.Point(4, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Calc);
            this.panel3.Location = new System.Drawing.Point(50, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 41);
            this.panel3.TabIndex = 8;
            // 
            // Calc
            // 
            this.Calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Calc.IconColor = System.Drawing.Color.Black;
            this.Calc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Calc.Location = new System.Drawing.Point(0, 0);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(120, 41);
            this.Calc.TabIndex = 0;
            this.Calc.Text = "Расчет";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // ClientAm
            // 
            this.ClientAm.Controls.Add(this.AddUser);
            this.ClientAm.Location = new System.Drawing.Point(50, 123);
            this.ClientAm.Name = "ClientAm";
            this.ClientAm.Size = new System.Drawing.Size(120, 41);
            this.ClientAm.TabIndex = 5;
            // 
            // AddUser
            // 
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddUser.IconColor = System.Drawing.Color.Black;
            this.AddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddUser.Location = new System.Drawing.Point(0, 0);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(120, 41);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Добавить Клиента\r\n";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 100);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::ProjectAvtoMoika.Properties.Resources._1564534_customer_man_user_account_profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(173, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(627, 394);
            this.panel6.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjectAvtoMoika.Properties.Resources.icons8_зеленый_щит_безопасности_64;
            this.pictureBox4.Location = new System.Drawing.Point(3, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // AvtoMoika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvtoMoika";
            this.Text = "AvtoMoika";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ClientAm.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel ClientAm;
        private FontAwesome.Sharp.IconButton AddUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton Calc;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton widebutton;
        private FontAwesome.Sharp.IconButton escapeButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}


namespace ProjectAvtoMoika
{
    partial class AdminPass
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
            this.Avtoriz = new System.Windows.Forms.Button();
            this.TextParol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизируйтесь в Админ панели";
            // 
            // Avtoriz
            // 
            this.Avtoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(214)))));
            this.Avtoriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Avtoriz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Avtoriz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Avtoriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Avtoriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Avtoriz.ForeColor = System.Drawing.Color.White;
            this.Avtoriz.Location = new System.Drawing.Point(89, 183);
            this.Avtoriz.Name = "Avtoriz";
            this.Avtoriz.Size = new System.Drawing.Size(130, 43);
            this.Avtoriz.TabIndex = 1;
            this.Avtoriz.Text = "Авторизация";
            this.Avtoriz.UseVisualStyleBackColor = false;
            this.Avtoriz.Click += new System.EventHandler(this.Avtoriz_Click);
            // 
            // TextParol
            // 
            this.TextParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextParol.Location = new System.Drawing.Point(89, 144);
            this.TextParol.Name = "TextParol";
            this.TextParol.Size = new System.Drawing.Size(130, 21);
            this.TextParol.TabIndex = 2;
            this.TextParol.Enter += new System.EventHandler(this.TextParol_Enter);
            this.TextParol.Leave += new System.EventHandler(this.TextParol_Leave);
            // 
            // AdminPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(148)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextParol);
            this.Controls.Add(this.Avtoriz);
            this.Controls.Add(this.label1);
            this.Name = "AdminPass";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Avtoriz;
        private System.Windows.Forms.TextBox TextParol;
    }
}
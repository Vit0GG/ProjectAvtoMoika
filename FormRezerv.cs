using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAvtoMoika
{
    public partial class AvtoMoika : Form
    {
        public AvtoMoika()
        {
            InitializeComponent();
        }

        private Form acriveForm1 = null; 
        private void openFormOper(Form form)
        {
            if (acriveForm1 != null) 
                acriveForm1.Close(); 
            acriveForm1 = form; // Сохранение ссылки на новую форму
            form.TopLevel = false; // Устанавка формы как подчиненную
            form.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            form.Dock = DockStyle.Fill; 
            panel6.Controls.Add(form); 
            panel6.Tag = form; 
            form.BringToFront();
            form.Show(); 

        }
        private Form activeForm2 = null; 
        private void openForm(Form form)
        {
            if (activeForm2 != null) 
                activeForm2.Close(); 
            activeForm2 = form; 
            form.TopLevel = false; 
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.Fill; 
            panel6.Controls.Add(form); 
            panel6.Tag = form; 
            form.BringToFront(); 
            form.Show(); 

        }
        private Form activeForm = null;
        private void openFormCalc(Form form)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel6.Controls.Add(form);
            panel6.Tag = form;
            form.BringToFront();
            form.Show();
        }
        
        private Form activeForm3 = null;
        private void openFormAdmin(Form form)
        {
            if (activeForm3 != null)
                activeForm3.Close();
            activeForm3 = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel6.Controls.Add(form);
            panel6.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void openFormAdminTable(Form form)
        {
            if (activeForm3 != null)
                activeForm3.Close();
            activeForm3 = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel6.Controls.Add(form);
            panel6.Tag = form;
            form.BringToFront();
            form.Show();
        }
        //Переменные для перетаскивания формы
        bool dragging = false;
        Point dragcursorpoit;
        Point dragFormrpoit;

        // Метод для минимизации формы
        private void escapeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Метод для изменения состояния окна (развернуть/нормальный)
        private void widebutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragcursorpoit = Cursor.Position;
            dragFormrpoit = this.Location;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragcursorpoit));
                this.Location = Point.Add(dragFormrpoit, new Size(dif));
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            openForm(new AddClient());
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            openFormCalc(new FormCacl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFormOper(new list_operations());
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            openFormAdmin(new AdminPass(openFormAdminTable));
        }
    }
}

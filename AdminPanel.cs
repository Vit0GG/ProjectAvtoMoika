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
    public partial class AdminPass : Form
    {
        private Action<Form> openFormAction; 

        public AdminPass(Action<Form> openFormAction)
        {
            InitializeComponent();
            this.openFormAction = openFormAction; 
            TextParol.Text = "Введите пароль: ";
            TextParol.UseSystemPasswordChar = false;
        }

        private void TextParol_Enter(object sender, EventArgs e)
        {
            if (TextParol.Text == "Введите пароль: ")
            {
                TextParol.Text = "";
                TextParol.UseSystemPasswordChar = true;
            }
        }

        private void TextParol_Leave(object sender, EventArgs e)
        {
            if (TextParol.Text == "")
            {
                TextParol.Text = "Введите пароль: ";
                TextParol.UseSystemPasswordChar = false;
            }
        }

        private void Avtoriz_Click(object sender, EventArgs e)
        {
            string correctPassword = "1111";

            if (TextParol.Text == "Введите пароль: ")
            {
                MessageBox.Show("Введите админ пароль!");
                return;
            }

            if (TextParol.Text == correctPassword)
            {
                MessageBox.Show("Пароль верный, доступ получен!");
                openFormAction(new AdminTable());
            }
            else
            {
                MessageBox.Show("Неверный пароль. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
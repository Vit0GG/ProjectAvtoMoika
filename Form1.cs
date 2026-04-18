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
            LoginField.Text = "Введите имя:";
            Nums.Text = "Введите номер авто:";
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите имя:")
            {
                MessageBox.Show("Введите Имя!");
                return;

            }
            if (Nums.Text == "Введите номер авто:")
            {
                MessageBox.Show("Введите Номер авто!");
                return;

            }
            bool userExists = checkUser();

            if (checkUser())
            {

                DB dB = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`Nums`, `Client`) VALUES (@Nums,@Client);", dB.GetConnection());

                command.Parameters.Add("@Nums", MySqlDbType.VarChar).Value = Nums.Text;
                command.Parameters.Add("@Client", MySqlDbType.VarChar).Value = LoginField.Text;

                dB.OpenCon();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Клиент добавлен");
                else
                    MessageBox.Show("Клиент не был добавлен");

                dB.CloseCon();
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите имя:")
            LoginField.Text = "";
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
                LoginField.Text = "Введите имя:";
        }

        private void Nums_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nums_Enter(object sender, EventArgs e)
        {
            if (Nums.Text == "Введите номер авто:")
                Nums.Text = "";
        }

        private void Nums_Leave(object sender, EventArgs e)
        {
            if (Nums.Text == "")
                Nums.Text = "Введите номер авто:";
        }

        
        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `clients` WHERE `Client` = @ul AND `Nums` = @nomer", db.GetConnection());

            cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginField.Text;
            cmd.Parameters.Add("@nomer", MySqlDbType.VarChar).Value = Nums.Text;
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                
                MessageBox.Show("Такой логин и номер уже есть, но вы можете продолжить.");
                return false; 
            }
            
            return true; 

        }
    }
}

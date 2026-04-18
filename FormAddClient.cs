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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            LoginField.Text = "Введите имя:";
            Nums.Text = "Введите номер авто:";
            NumberMob.Text = "Введите телефон:";
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (NumberMob.Text == "Введите телефон:")
            {
                MessageBox.Show("Введите номер телефона!");
                return;
            }

            bool userExists = checkUser();

            if (checkUser())
            {

                DB dB = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`Nums`, `Client`,`NumsMob`) VALUES (@Nums,@Client,@NumsMob);", dB.GetConnection());

                command.Parameters.Add("@Nums", MySqlDbType.VarChar).Value = Nums.Text;
                command.Parameters.Add("@Client", MySqlDbType.VarChar).Value = LoginField.Text;
                command.Parameters.Add("@NumsMob", MySqlDbType.VarChar).Value = NumberMob.Text;
                dB.OpenCon();

                if (command.ExecuteNonQuery() == 1)
                {
                    //получение ID последнего вставленного клиента
                    long newClientId = command.LastInsertedId;
                    MessageBox.Show($"Клиент добавлен,его id: (ID: {newClientId})");
                }
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
        //метод для проверки существования пользователя в базе данных
        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `clients` WHERE `Client` = @ul AND `Nums` = @nomer AND `NumsMob` = @tel ", db.GetConnection());

            cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginField.Text;
            cmd.Parameters.Add("@nomer", MySqlDbType.VarChar).Value = Nums.Text;
            cmd.Parameters.Add("@tel", MySqlDbType.Int64).Value = NumberMob.Text;
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable); //Заполнение таблицы результатами запроса

            if (dataTable.Rows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataTable.Rows[0]["id"]);
                MessageBox.Show($"Такой логин и номер уже есть, но вы можете продолжить.\nЕго id: (ID: {clientId})");
                return false;

            }
            return true;

        }

        private void NumberMob_Enter(object sender, EventArgs e)
        {
            if (NumberMob.Text == "Введите телефон:")
                NumberMob.Text = "";
        }

        private void NumberMob_Leave(object sender, EventArgs e)
        {
            if (NumberMob.Text == "")
                NumberMob.Text = "Введите телефон:";
        }
    }
}

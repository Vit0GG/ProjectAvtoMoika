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
    public partial class AdminTable : Form
    {
        public AdminTable()
        {
            InitializeComponent();
            TextUsluga.Text = "Введите наименование услуги: ";
            TextCostUsluga.Text = "Введите стоимость услуги: ";
            TextTimeUsluga.Text = "Введите время выполнения: ";
            TextTipKuzov.Text = "Введите название кузова: ";
            TextXCost.Text = "Введите множитель цены: ";
            TextXTime.Text = "Введите множитель времени: ";

        }
        private void AddUslugi_Click(object sender, EventArgs e)
        {
            if (TextUsluga.Text == "Введите наименование услуги: ")
            {
                MessageBox.Show("Введите услугу!");
                return;

            }
            if (TextCostUsluga.Text == "Введите стоимость услуги: ")
            {
                MessageBox.Show("Введите стоимость!");
                return;

            }
            if (TextTimeUsluga.Text == "Введите время выполнения: ")
            {
                MessageBox.Show("Введите время!");
                return;
            }
            

            bool UslugiExists = checkUslugi();
            if (!UslugiExists) 
            {
                MessageBox.Show("Такой тип услуги уже есть, но вы можете продолжить.");
                return;
            }

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `uslugi` (`Usluga`, `Cost`, `time`) VALUES (@usluga, @cost, @time);", dB.GetConnection());

            command.Parameters.Add("@usluga", MySqlDbType.VarChar).Value = TextUsluga.Text;
            command.Parameters.Add("@cost", MySqlDbType.Float).Value = float.Parse(TextCostUsluga.Text);
            command.Parameters.Add("@time", MySqlDbType.Float).Value = float.Parse(TextTimeUsluga.Text);

            try
            {
                dB.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Услуга успешно добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                dB.CloseCon();
            }

        }
        public Boolean checkUslugi()
        {
            DB db = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `uslugi` WHERE `Usluga` = @usl AND `Cost` = @cost AND `time` = @time ", db.GetConnection());

            cmd.Parameters.Add("@usl", MySqlDbType.VarChar).Value = TextUsluga.Text;
            cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = float.Parse(TextCostUsluga.Text);
            cmd.Parameters.Add("@time", MySqlDbType.Float).Value = float.Parse(TextTimeUsluga.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show($"Такой тип услуги уже есть, но вы можете продолжить.");
                return false;

            }
            return true;

        }
        private void TextUsluga_Enter(object sender, EventArgs e)
        {

            if (TextUsluga.Text == "Введите наименование услуги: ")
                TextUsluga.Text = "";
        }

        private void TextCostUsluga_Leave(object sender, EventArgs e)
        {
            if (TextCostUsluga.Text == "")
                TextCostUsluga.Text = "Введите стоимость услуги: ";
        }

        private void TextUsluga_Leave(object sender, EventArgs e)
        {
            if (TextUsluga.Text == "")
                TextUsluga.Text = "Введите наименование услуги: ";
        }

        private void TextCostUsluga_Enter(object sender, EventArgs e)
        {
            if (TextCostUsluga.Text == "Введите стоимость услуги: ")
                TextCostUsluga.Text = "";
        }

        private void TextTimeUsluga_Enter(object sender, EventArgs e)
        {
            if (TextTimeUsluga.Text == "Введите время выполнения: ")
                TextTimeUsluga.Text = "";
        }

        private void TextTimeUsluga_Leave(object sender, EventArgs e)
        {
            if (TextTimeUsluga.Text == "")
                TextTimeUsluga.Text = "Введите время выполнения: ";
        }

        private void TextTipKuzov_Enter(object sender, EventArgs e)
        {
            if (TextTipKuzov.Text == "Введите название кузова: ")
                TextTipKuzov.Text = "";
        }

        private void TextTipKuzov_Leave(object sender, EventArgs e)
        {
            if (TextTipKuzov.Text == "")
                TextTipKuzov.Text = "Введите название кузова: ";
        }

        private void TextXCost_Enter(object sender, EventArgs e)
        {
            if (TextXCost.Text == "Введите множитель цены: ")
                TextXCost.Text = "";
        }

        private void TextXCost_Leave(object sender, EventArgs e)
        {
            if (TextXCost.Text == "")
                TextXCost.Text = "Введите множитель цены: ";
        }

        private void TextXTime_Enter(object sender, EventArgs e)
        {
            if (TextXTime.Text == "Введите множитель времени: ")
                TextXTime.Text = "";
        }

        private void TextXTime_Leave(object sender, EventArgs e)
        {
            if (TextXTime.Text == "")
                TextXTime.Text = "Введите множитель времени: ";
        }

        private void AddKuzova_Click(object sender, EventArgs e)
        {
            if (TextTipKuzov.Text == "Введите название кузова: ")
            {
                MessageBox.Show("Введите название кузова!");
                return;

            }
            if (TextXCost.Text == "Введите множитель цены: ")
            {
                MessageBox.Show("Введите множитель цены!");
                return;

            }
            if (TextXTime.Text == "Введите множитель времени: ")
            {
                MessageBox.Show("Введите множитель времени!");
                return;
            }
            bool KuzovExists = checkKuzov();
            if (!KuzovExists) 
            {
                MessageBox.Show("Такой тип кузова уже есть, но вы можете продолжить.");
                return;
            }

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kuzova` (`KuZOV`, `Xtime`, `XCost`) VALUES (@kuzov, @xcost, @xtime);", dB.GetConnection());

            command.Parameters.Add("@kuzov", MySqlDbType.VarChar).Value = TextTipKuzov.Text;
            command.Parameters.Add("@xcost", MySqlDbType.Float).Value = float.Parse(TextXCost.Text);
            command.Parameters.Add("@xtime", MySqlDbType.Float).Value = float.Parse(TextXTime.Text);

            try
            {
                dB.OpenCon();
                command.ExecuteNonQuery(); 
                MessageBox.Show("Кузов успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                dB.CloseCon();
            }
        }
        public Boolean checkKuzov()
        {
            DB db = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `kuzova` WHERE `KuZOV` = @kuz AND `XCost` = @xcost AND `Xtime` = @xtime ", db.GetConnection());

            cmd.Parameters.Add("@kuz", MySqlDbType.VarChar).Value = TextTipKuzov.Text;
            cmd.Parameters.Add("@xcost", MySqlDbType.Float).Value = float.Parse(TextXCost.Text);
            cmd.Parameters.Add("@xtime", MySqlDbType.Float).Value = float.Parse(TextXTime.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable); 

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show($"Такой тип кузова уже есть, но вы можете продолжить.");
                return false;

            }
            return true;

        }
    }
}

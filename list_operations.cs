using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectAvtoMoika
{
    public partial class list_operations : Form
    {
        public list_operations()
        {
            InitializeComponent();
            NumsMob.Text = "Введите номер телефона:";
            Kuzova.Text = "Выберите тип кузова:";
            LoadKuzova();
            LoadUslugi();
            dateTimePicker1.Format = DateTimePickerFormat.Custom; 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            
        }

        private void LoadKuzova()
        {
            using (DB dB = new DB())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `kuzova`", dB.GetConnection());
                dB.OpenCon();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kuzova.Items.Add(reader["KuZOV"].ToString());
                    }
                }
            }
        }

        private void LoadUslugi()
        {
            using (DB dB = new DB())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `uslugi`", dB.GetConnection());
                dB.OpenCon();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chekedUslugi.Items.Add(reader["Usluga"].ToString());
                    }
                }
            }
        }

        private void NumsMob_Click(object sender, EventArgs e)
        {
            if (NumsMob.Text == "Введите номер телефона:")
            {
                MessageBox.Show("Введите номер телефона!");
                return;
            }
        }

        private void ClearFields()
        {
            dateTimePicker1.Value = DateTime.Now; 
            NumsMob.Text = "Введите номер телефона:"; 
            Kuzova.SelectedIndex = -1; 
            foreach (int index in chekedUslugi.CheckedIndices)
            {
                chekedUslugi.SetItemChecked(index, false); 
            }
        }

        private void NumsMob_Enter(object sender, EventArgs e)
        {
            if (NumsMob.Text == "Введите номер телефона:")
                NumsMob.Text = "";
        }

        private void NumsMob_Leave(object sender, EventArgs e)
        {
            if (NumsMob.Text == "")
                NumsMob.Text = "Введите номер телефона:";
        }

        private void Add_List_Click(object sender, EventArgs e)
        {
            
            if (NumsMob.Text == "Введите номер телефона:")
            {
                MessageBox.Show("Введите номер телефона клиента!");
                return; 
            }

            if (Kuzova.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип кузова!");
                return;
            }

            
            if (chekedUslugi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну услугу!");
                return; 
            }

            
            DateTime selectedDate = dateTimePicker1.Value; 
            string clientNumber = NumsMob.Text; 
            string selectedKuzova = Kuzova.SelectedItem?.ToString(); 
            List<string> selectedServices = new List<string>();

            foreach (var item in chekedUslugi.CheckedItems)
            {
                selectedServices.Add(item.ToString());
            }

            // Объединяем все выбранные услуги в одну строку, разделяя запятыми
            string servicesString = string.Join(", ", selectedServices);

            try
            {
                using (DB dB = new DB())
                {
                    dB.OpenCon();

                    // Вставляем данные о клиенте, кузове и услугах
                    MySqlCommand command = new MySqlCommand("INSERT INTO `list_operations` (`Data`, `NumsMob`, `TipKuzov`, `Uslugi`) VALUES (@date, @numsMob, @kuzovaType, @services);", dB.GetConnection());

                    command.Parameters.Add("@date", MySqlDbType.DateTime).Value = selectedDate;
                    command.Parameters.Add("@numsMob", MySqlDbType.Int64).Value = long.Parse(clientNumber); 
                    command.Parameters.Add("@kuzovaType", MySqlDbType.VarChar).Value = selectedKuzova;
                    command.Parameters.Add("@services", MySqlDbType.VarChar).Value = servicesString; 
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!");
                }

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAvtoMoika
{
    public partial class FormCacl : Form
    {
        public FormCacl()
        {
            InitializeComponent();
            LoadKuzova();
            LoadUslugi();
            TipsKuzov.Text = "Выберите тип кузова:";
        }

        public class Usluga
        {
            public string Name { get; set; }
            public float Cost { get; set; }
            public float Time { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Cost} рублей, {Time} минут";
            }
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
                        TipsKuzov.Items.Add(reader["KuZOV"].ToString());
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
                        string uslugaName = reader["Usluga"].ToString();
                        float cost = reader.GetFloat("Cost");
                        float time = reader.GetFloat("time");

                        Usluga usluga = new Usluga
                        {
                            Name = uslugaName,
                            Cost = cost,
                            Time = time
                        };

                        Uslugi.Items.Add(usluga);
                    }
                }
            }
        }

        private void Schet_Click(object sender, EventArgs e)
        {
            if (TipsKuzov.SelectedItem == null || Uslugi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите кузов и хотя бы одну услугу.");
                return;
            }
            // Получаем выбранный кузов
            string selectedKuzov = TipsKuzov.SelectedItem.ToString();
            float totalCost = 0;
            float totalTime = 0;

            using (DB dB = new DB())
            {
                dB.OpenCon();

                MySqlCommand kuzovCommand = new MySqlCommand("SELECT `XCost`, `Xtime` FROM `kuzova` WHERE `KuZOV` = @kuzov", dB.GetConnection());
                kuzovCommand.Parameters.Add("@kuzov", MySqlDbType.VarChar).Value = selectedKuzov;

                using (MySqlDataReader kuzovReader = kuzovCommand.ExecuteReader())
                {
                    if (kuzovReader.Read())
                    {
                        float xCost = kuzovReader.GetFloat("XCost");
                        float xTime = kuzovReader.GetFloat("Xtime");
                        kuzovReader.Close(); 

                        // Проходим по всем выбранным услугам
                        foreach (Usluga selectedItem in Uslugi.CheckedItems)
                        {
                            totalCost += xCost * selectedItem.Cost;
                            totalTime += xTime * selectedItem.Time;
                        }

                        MessageBox.Show($"Общая стоимость: {totalCost} рублей\nОбщее время: {totalTime} минут");
                    }
                    else
                    {
                        MessageBox.Show("Кузов не найден.");
                    }
                }
            }
        }

        private void TipsKuzov_Enter(object sender, EventArgs e)
        {
            if (TipsKuzov.Text == "Выберите тип кузова:")
                TipsKuzov.Text = "";
        }

        private void TipsKuzov_Leave(object sender, EventArgs e)
        {
            if (TipsKuzov.Text == "")
                TipsKuzov.Text = "Выберите тип кузова:";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BonusCardApp
{
    public partial class Form3 : Form
    {
        public static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Карты.mdb"; // создали подключение к базе
        private OleDbConnection myConnection; // дали подключению название
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open(); // открыли подключение
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "картыDataSet.Карты". При необходимости она может быть перемещена или удалена.
            this.картыTableAdapter.Fill(this.картыDataSet.Карты);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            int kod_2 = Convert.ToInt32(textBox2.Text);
            string customer = textBox3.Text;
            string number = textBox4.Text;
            string profit = textBox5.Text;
            string discont = textBox6.Text;
            string bonus = textBox7.Text;

            string query = "INSERT INTO Карты ([Код карты],[Код клиента], Клиент, Номер, Сумма, Скидка, Бонусы) VALUES (" + kod + ", " + kod_2 +",'" + customer + "', '" + number + "', '" + profit + "','" + discont + "', '" + bonus + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Бонус добавлен");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double profit;
            double discont;

            profit = Convert.ToDouble(textBox5.Text);
            discont = Convert.ToDouble(textBox6.Text);

            switch (comboBox1.Text)
            {
                case "*":

                    textBox7.Text = Convert.ToString(profit * discont / 100);
                    break;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.картыTableAdapter.Fill(this.картыDataSet.Карты);
        }

        
    }
}

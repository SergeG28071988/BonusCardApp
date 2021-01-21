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
    public partial class Form2 : Form
    {
        public static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Карты.mdb"; // создали подключение к базе
        private OleDbConnection myConnection; // дали подключению название
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open(); // открыли подключение
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string surname = textBox2.Text;
            string name = textBox3.Text;
            string middle_name = textBox4.Text;            
            string phone = textBox6.Text;

            string query = "INSERT INTO Клиенты ([Код клиента], Фамилия, Имя, Отчество, Телефон) VALUES (" + kod + ", '" + surname + "', '" + name + "', '" + middle_name + "','" + phone + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Клиент добавлен");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}

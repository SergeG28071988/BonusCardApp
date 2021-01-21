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
    public partial class Form1 : Form
    {
        public static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Карты.mdb"; // создали подключение к базе
        private OleDbConnection myConnection; // дали подключению название
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString); 
            myConnection.Open(); // открыли подключение

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "картыDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.картыDataSet.Клиенты);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close(); // закрываем соединение чтобы не было утечки памяти
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Клиенты WHERE [Код клиента]=" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Клиент удалён");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Клиенты  SET Фамилия ='" + textBox3.Text + "'WHERE [Код клиента]=" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("фамилия изменена");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); 
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.Fill(this.картыDataSet.Клиенты);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

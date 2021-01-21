
namespace BonusCardApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.картыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.картыDataSet = new BonusCardApp.КартыDataSet();
            this.картыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.картыTableAdapter = new BonusCardApp.КартыDataSetTableAdapters.КартыTableAdapter();
            this.картыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.картыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бонусыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.картыBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код карты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Скидка,%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Бонусы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(845, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(855, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(828, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(826, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(826, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(840, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(830, 179);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*"});
            this.comboBox1.Location = new System.Drawing.Point(782, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Рассчитать бонусы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // картыBindingSource3
            // 
            this.картыBindingSource3.DataMember = "Карты";
            this.картыBindingSource3.DataSource = this.картыDataSet;
            // 
            // картыDataSet
            // 
            this.картыDataSet.DataSetName = "КартыDataSet";
            this.картыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // картыBindingSource
            // 
            this.картыBindingSource.DataMember = "Карты";
            this.картыBindingSource.DataSource = this.картыDataSet;
            // 
            // картыTableAdapter
            // 
            this.картыTableAdapter.ClearBeforeFill = true;
            // 
            // картыBindingSource1
            // 
            this.картыBindingSource1.DataMember = "Карты";
            this.картыBindingSource1.DataSource = this.картыDataSet;
            // 
            // картыBindingSource2
            // 
            this.картыBindingSource2.DataMember = "Карты";
            this.картыBindingSource2.DataSource = this.картыDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКартыDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.бонусыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.картыBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 308);
            this.dataGridView1.TabIndex = 18;
            // 
            // кодКартыDataGridViewTextBoxColumn
            // 
            this.кодКартыDataGridViewTextBoxColumn.DataPropertyName = "Код карты";
            this.кодКартыDataGridViewTextBoxColumn.HeaderText = "Код карты";
            this.кодКартыDataGridViewTextBoxColumn.Name = "кодКартыDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            // 
            // бонусыDataGridViewTextBoxColumn
            // 
            this.бонусыDataGridViewTextBoxColumn.DataPropertyName = "Бонусы";
            this.бонусыDataGridViewTextBoxColumn.HeaderText = "Бонусы";
            this.бонусыDataGridViewTextBoxColumn.Name = "бонусыDataGridViewTextBoxColumn";
            // 
            // картыBindingSource4
            // 
            this.картыBindingSource4.DataMember = "Карты";
            this.картыBindingSource4.DataSource = this.картыDataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(747, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1046, 383);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Рассчитать бонусы";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картыBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private КартыDataSet картыDataSet;
        private System.Windows.Forms.BindingSource картыBindingSource;
        private КартыDataSetTableAdapters.КартыTableAdapter картыTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource картыBindingSource1;
        private System.Windows.Forms.BindingSource картыBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn бонусовНачисленоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource картыBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бонусыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource картыBindingSource4;
        private System.Windows.Forms.Button button3;
    }
}
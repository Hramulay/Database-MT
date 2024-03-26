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

namespace pup
{
    public partial class Form5 : Form
    {
        public static string BD = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = BD.mdb";
        private OleDbConnection BDConnect;
        public Form5()
        {
            InitializeComponent();
            BDConnect = new OleDbConnection(BD);
            BDConnect.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Справочник_сотрудников". При необходимости она может быть перемещена или удалена.
            this.справочник_сотрудниковTableAdapter.Fill(this.bDDataSet.Справочник_сотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Справочник_подразделения". При необходимости она может быть перемещена или удалена.
            this.справочник_подразделенияTableAdapter.Fill(this.bDDataSet.Справочник_подразделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet._Таблица__Данные_". При необходимости она может быть перемещена или удалена.
            this.таблица__Данные_TableAdapter1.Fill(this.bDDataSet._Таблица__Данные_);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            Hide();
        }

        private void ПерезагрукаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ЗавершениеРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void СменитьУчётнуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Hide();
        }

        private void СправочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            справочник_сотрудниковTableAdapter.Update(bDDataSet);
            MessageBox.Show("Изменения сохранены");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            BDConnect.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}

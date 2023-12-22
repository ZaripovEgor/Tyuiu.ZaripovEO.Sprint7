using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ZaripovEO.Sprint7.V8
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            FormMain Grid = new FormMain();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain Grid = new FormMain();

                int rowsCount = Grid.dataGridView1.Rows.Count;
                string[] str = { textBox_A.Text, textBox_B.Text, textBox_C.Text, textBox_D.Text, textBox_E.Text, textBox_F.Text, textBox_G.Text };
                Grid.insert_data(str);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

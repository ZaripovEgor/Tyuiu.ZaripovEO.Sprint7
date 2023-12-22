using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.ZaripovEO.Sprint7.V8
{
    public partial class FormMain : Form
    {
        public static int ugly = 0;
        public FormMain()
        {
            InitializeComponent();
            if (ugly==0)
            {
                FormWelcome IDCheck = new FormWelcome();
                IDCheck.ShowDialog();
                ugly++; 
            }
        }
        public void insert_data(string[] str)
        {
            dataGridView1.Rows.Add();
            //dataGridView1.Rows.Add(str[0], str[1], str[2], str[3], str[4], str[5], str[6]);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (FormWelcome.u == 1)
            {
                Close();
            }
            else
            {
                labelPersonal.Text = $"Сотрудник:{FormWelcome.Name}";
            }
        }

        static string filePath;

        static int rows;
        static int columns;
        static string[,] arrayPlates;

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            openFileDialogCSV.ShowDialog();
            filePath = openFileDialogCSV.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(filePath);

            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            dataGridView1.RowCount = rows;
            dataGridView1.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 120;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayPlates = new string[rows, columns];
            for (int i = 0; i < arrayValues.GetLength(0); i++)
            {
                comboBox1.Items.Add(arrayValues[i, 0]);
            }
        }

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            List<string> lines = File.ReadAllLines(filePath).ToList();

            File.WriteAllLines(filePath, lines);
            fileData = fileData.Replace('\n', '\r');
            string[] liness = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = liness.Length;
            columns = liness[0].Split(';').Length;
            arrayPlates = new string[rows, columns];
            string[,] arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = (line_r[c]);
                }
            }
            return arrayValues;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(comboBox1.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                        }        
                    }
                }
            }
        }

        private void buttonAddValues_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.Owner = this;
            formAdd.Show();
        }
    }
}

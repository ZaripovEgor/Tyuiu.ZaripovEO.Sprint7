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
        public FormMain()
        {
            InitializeComponent();
            FormWelcomeCheck IDCheck = new FormWelcomeCheck();
            IDCheck.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelPersonal.Text = $"Сотрудник:{FormWelcomeCheck.Name}";
        }

        static string filePath;
        static string[,] array;
        static int rows;
        static int columns;


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
        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

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
    }
}

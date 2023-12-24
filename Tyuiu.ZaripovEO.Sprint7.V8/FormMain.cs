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
            if (ugly == 0)
            {
                FormWelcome IDCheck = new FormWelcome();
                IDCheck.ShowDialog();
                ugly++;
            }
            labelDate.Text = DateTime.Now.ToShortDateString();
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
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogCSV.ShowDialog();
                filePath = openFileDialogCSV.FileName;

                string[,] arrayValues = new string[rows, columns];
                arrayValues = LoadFromFileData(filePath);

                dataGridViewMain.ColumnCount = columns;
                dataGridViewMain.RowCount = rows;
                dataGridViewMain.RowCount = rows;
                dataGridViewMain.ColumnCount = columns;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMain.Columns[i].Width = 115;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewMain.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                for (int i = 0; i < arrayValues.GetLength(0); i++)
                {
                    comboBoxValues.Items.Add(arrayValues[i, 0]);
                }
                buttonUpdate.Enabled = true;
                buttonDeleteRow.Enabled = true;
                buttonAdd.Enabled = true;
                buttonAddNotReal.Enabled = true;
                comboBoxValues.Enabled = true;
                buttonSave.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Действие не выполнено", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static int k;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridViewMain.RowCount; i++)
                {
                    dataGridViewMain.Rows[i].Selected = false;
                    dataGridViewMain.Rows[i].Visible = false;
                    for (int j = 0; j < dataGridViewMain.ColumnCount; j++)
                    {
                        if (dataGridViewMain.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridViewMain.Rows[i].Cells[j].Value.ToString().Contains(comboBoxValues.Text))
                            {
                                dataGridViewMain.Rows[i].Visible = true;
                                k = i;
                                dataGridViewMain.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void buttonAddValues_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string VarA = textBox_A.Text;
                string VarB = textBox_B.Text;
                string VarC = textBox_C.Text;
                string VarD = textBox_F.Text;
                string VarE = textBox_D.Text;
                string VarF = textBox_E.Text;
                string VarG = textBox_G.Text;
                if (string.IsNullOrEmpty(VarE))
                {
                    MessageBox.Show("Неверно введены значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridViewAdd.Rows.Clear();
                    dataGridViewAdd.Rows.Add(VarA, VarB, VarC, VarD, VarE, VarF, VarG);
                }
                buttonConfirm.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неверно введены значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите добавить \nвыбранные элементы?", "Запись", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int rowsCount = dataGridViewMain.Rows.Count - 1;
                    dataGridViewMain.Rows.Add(textBox_A.Text, textBox_B.Text, textBox_C.Text, textBox_D.Text, textBox_E.Text, textBox_F.Text, textBox_G.Text);
                }
                catch
                {
                    MessageBox.Show("Неверно введены значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridViewMain.Rows.RemoveAt(k);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            comboBoxValues.Items.Clear();
            for (int i = 0; i < dataGridViewMain.RowCount; i++)
            {
                dataGridViewMain.Rows[i].Visible = true;
                comboBoxValues.Items.Add(dataGridViewMain.Rows[i].Cells[0].Value);
            }
        }

        private void buttonChartSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                chartMain.Series[0].Points.Clear();
                chartMain.Series[1].Points.Clear();
                chartMain.Series[2].Points.Clear();
                chartMain.Titles.Clear();
                chartMain.Titles.Add("Средняя скорость, км/ч");
                chartMain.ChartAreas[0].AxisX.Title = "Государственный номер";
                chartMain.ChartAreas[0].AxisY.Title = "км/ч";
                chartMain.ChartAreas[0].AxisX.Interval = 1;
                chartMain.ChartAreas[0].AxisY.Interval = 5;
                string max;
                string min;
                string[] array = new string[dataGridViewMain.RowCount];
                for (int i = 0; i < dataGridViewMain.RowCount - 1; i++)
                {
                    array[i] = dataGridViewMain[4, i].Value.ToString();
                    chartMain.Series[0].Points.AddXY(dataGridViewMain.Rows[i].Cells[0].Value, dataGridViewMain.Rows[i].Cells[4].Value);
                }
                max = Convert.ToString(array.Max());
                min = Convert.ToString(array.Min());
                textBoxMaxValue.Text = Convert.ToString(max);
                textBoxMinValue.Text = Convert.ToString(min);
                int IndexMaxVal = Array.IndexOf(array, max);
                int IndexMinVal = Array.IndexOf(array, min);

                textBoxMaxNumber.Text = (string)dataGridViewMain.Rows[IndexMaxVal].Cells[0].Value;
                textBoxMinNumber.Text = (string)dataGridViewMain.Rows[IndexMinVal].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("Невозможно прочитать таблицу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //const int Scroll = 10;
            //if (chartMain.ChartAreas[0].AxisX.ScaleView.Size > Scroll)
            //{
            //    chartMain.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            //    chartMain.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            //    chartMain.ChartAreas[0].AxisX.ScaleView.Size = Scroll;
            //    chartMain.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            //}
        }

        private void buttonChartWeight_Click(object sender, EventArgs e)
        {
            try
            {
                chartMain.Series[0].Points.Clear();
                chartMain.Series[1].Points.Clear();
                chartMain.Series[2].Points.Clear();
                chartMain.Titles.Clear();
                chartMain.Titles.Add("Грузоподъёмность, кг");
                chartMain.ChartAreas[0].AxisX.Title = "Государственный номер";
                chartMain.ChartAreas[0].AxisY.Title = "кг";
                chartMain.ChartAreas[0].AxisX.Interval = 1;
                chartMain.ChartAreas[0].AxisY.Interval = 200;
                string max;
                string min;
                string[] array = new string[dataGridViewMain.RowCount];
                for (int i = 0; i < dataGridViewMain.RowCount - 1; i++)
                {
                    array[i] = dataGridViewMain[5, i].Value.ToString();
                    chartMain.Series[1].Points.AddXY(dataGridViewMain.Rows[i].Cells[0].Value, dataGridViewMain.Rows[i].Cells[5].Value);
                }
                max = Convert.ToString(array.Max());
                min = Convert.ToString(array.Min());
                textBoxMaxValue.Text = Convert.ToString(max);
                textBoxMinValue.Text = Convert.ToString(min);
                int IndexMaxVal = Array.IndexOf(array, max);
                int IndexMinVal = Array.IndexOf(array, min);

                textBoxMaxNumber.Text = (string)dataGridViewMain.Rows[IndexMaxVal].Cells[0].Value;
                textBoxMinNumber.Text = (string)dataGridViewMain.Rows[IndexMinVal].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("Невозможно прочитать таблицу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChartFuel_Click(object sender, EventArgs e)
        {
            try
            {
                chartMain.Series[0].Points.Clear();
                chartMain.Series[1].Points.Clear();
                chartMain.Series[2].Points.Clear();
                chartMain.Titles.Clear();
                chartMain.Titles.Add("Потребление топлива на 100 км, л");
                chartMain.ChartAreas[0].AxisX.Title = "Государственный номер";
                chartMain.ChartAreas[0].AxisY.Title = "л";
                chartMain.ChartAreas[0].AxisY.Interval = 2;
                chartMain.ChartAreas[0].AxisX.Interval = 1;
                string max;
                string min;
                string[] array = new string[dataGridViewMain.RowCount];
                for (int i = 0; i < dataGridViewMain.RowCount - 1; i++)
                {
                    array[i] = dataGridViewMain[6, i].Value.ToString();
                    chartMain.Series[2].Points.AddXY(dataGridViewMain.Rows[i].Cells[0].Value, dataGridViewMain.Rows[i].Cells[6].Value);
                }
                max = Convert.ToString(array.Max());
                min = Convert.ToString(array.Min());
                textBoxMaxValue.Text = Convert.ToString(max);
                textBoxMinValue.Text = Convert.ToString(min);
                int IndexMaxVal = Array.IndexOf(array, max);
                int IndexMinVal = Array.IndexOf(array, min);

                textBoxMaxNumber.Text = (string)dataGridViewMain.Rows[IndexMaxVal].Cells[0].Value;
                textBoxMinNumber.Text = (string)dataGridViewMain.Rows[IndexMinVal].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("Невозможно прочитать таблицу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(!char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Это поле не принимает цифры");
                e.Handled = true;
            }
        }

        private void textBox_G_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == '.') || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Это поле принимает только цифры и знак точки");
                e.Handled = true;
            }
        }

        private void textBox_F_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Это поле принимает только цифры");
                e.Handled = true;
            }
        }

        private void textBox_E_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == '.') || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Это поле принимает только цифры и знак точки");
                e.Handled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMatrix.FileName = "DataBaseOutPut.csv";
                saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogMatrix.ShowDialog();

                string path = saveFileDialogMatrix.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }
                int rows = dataGridViewMain.RowCount;
                int columns = dataGridViewMain.ColumnCount;
                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewMain.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str +=  dataGridViewMain.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Неожиданнавя ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGotoTable_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;
        }

        private void buttonGotoAdd_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void buttonGotoChart_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 3;
        }

        private void buttonGotoMenu_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void buttonAddHelp_Click(object sender, EventArgs e)
        {
            FormAddHelp form = new FormAddHelp();
            form.ShowDialog();
        }

        private void buttonAboutDev_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
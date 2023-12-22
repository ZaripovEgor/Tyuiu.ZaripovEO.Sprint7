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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        public static new string Name;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxCheckName.Text == "001")
            {
                Name = "Зарипов Е. О.";
                Close();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Name = "Гость";
            Close();
        }
        public static int u;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            u++;
            this.Close();
        }

    }
}

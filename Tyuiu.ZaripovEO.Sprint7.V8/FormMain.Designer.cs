
namespace Tyuiu.ZaripovEO.Sprint7.V8
{
    partial class FormMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWhere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnV_avrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialogCSV = new System.Windows.Forms.OpenFileDialog();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMenu);
            this.tabControlMain.Controls.Add(this.tabPageTable);
            this.tabControlMain.Controls.Add(this.tabPageChart);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 49);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(961, 471);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(972, 445);
            this.tabPageMenu.TabIndex = 0;
            this.tabPageMenu.Text = "Главное меню";
            this.tabPageMenu.UseVisualStyleBackColor = true;
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.buttonChoose);
            this.tabPageTable.Controls.Add(this.dataGridView1);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(953, 445);
            this.tabPageTable.TabIndex = 1;
            this.tabPageTable.Text = "Таблица";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(972, 445);
            this.tabPageChart.TabIndex = 2;
            this.tabPageChart.Text = "График";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPersonal);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 49);
            this.panel1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(245, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(476, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Автотранспортное предприятие г. Тюмень";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 471);
            this.panel2.TabIndex = 2;
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.Location = new System.Drawing.Point(12, 18);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(0, 13);
            this.labelPersonal.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColumnNumPlate,
            this.ColumnAuto,
            this.ColumnWhere,
            this.ColumnV_avrg,
            this.ColumnMaxWeight,
            this.ColumnFuel});
            this.dataGridView1.Location = new System.Drawing.Point(275, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(672, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "№";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // ColumnNumPlate
            // 
            this.ColumnNumPlate.HeaderText = "Гос. Номер";
            this.ColumnNumPlate.Name = "ColumnNumPlate";
            this.ColumnNumPlate.ReadOnly = true;
            // 
            // ColumnAuto
            // 
            this.ColumnAuto.HeaderText = "Марка авто";
            this.ColumnAuto.Name = "ColumnAuto";
            this.ColumnAuto.ReadOnly = true;
            // 
            // ColumnWhere
            // 
            this.ColumnWhere.HeaderText = "Местонахождение";
            this.ColumnWhere.Name = "ColumnWhere";
            this.ColumnWhere.ReadOnly = true;
            this.ColumnWhere.Width = 120;
            // 
            // ColumnV_avrg
            // 
            this.ColumnV_avrg.HeaderText = "V-средняя";
            this.ColumnV_avrg.Name = "ColumnV_avrg";
            this.ColumnV_avrg.ReadOnly = true;
            // 
            // ColumnMaxWeight
            // 
            this.ColumnMaxWeight.HeaderText = "Грузоподъёмность";
            this.ColumnMaxWeight.Name = "ColumnMaxWeight";
            this.ColumnMaxWeight.ReadOnly = true;
            this.ColumnMaxWeight.Width = 120;
            // 
            // ColumnFuel
            // 
            this.ColumnFuel.HeaderText = "Расход топлива";
            this.ColumnFuel.Name = "ColumnFuel";
            this.ColumnFuel.ReadOnly = true;
            // 
            // openFileDialogCSV
            // 
            this.openFileDialogCSV.FileName = "openFileDialogCSV";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(11, 16);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(122, 28);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "Выбрать CSV...";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 520);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автотранспортное предприятие";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnV_avrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFuel;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.OpenFileDialog openFileDialogCSV;
    }
}


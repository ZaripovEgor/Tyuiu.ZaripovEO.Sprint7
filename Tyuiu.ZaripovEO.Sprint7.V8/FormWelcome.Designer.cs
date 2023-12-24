
namespace Tyuiu.ZaripovEO.Sprint7.V8
{
    partial class FormWelcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCheckName = new System.Windows.Forms.TextBox();
            this.labelCheckName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonAsGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!\r\n\r\nПожалуйста, назовитесь:";
            // 
            // textBoxCheckName
            // 
            this.textBoxCheckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCheckName.Location = new System.Drawing.Point(348, 79);
            this.textBoxCheckName.Name = "textBoxCheckName";
            this.textBoxCheckName.Size = new System.Drawing.Size(100, 21);
            this.textBoxCheckName.TabIndex = 1;
            // 
            // labelCheckName
            // 
            this.labelCheckName.AutoSize = true;
            this.labelCheckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheckName.Location = new System.Drawing.Point(365, 60);
            this.labelCheckName.Name = "labelCheckName";
            this.labelCheckName.Size = new System.Drawing.Size(56, 16);
            this.labelCheckName.TabIndex = 2;
            this.labelCheckName.Text = "Ваш ID";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(430, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 21);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Х";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(336, 123);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 37);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonAsGuest
            // 
            this.buttonAsGuest.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAsGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAsGuest.ForeColor = System.Drawing.Color.White;
            this.buttonAsGuest.Location = new System.Drawing.Point(18, 123);
            this.buttonAsGuest.Name = "buttonAsGuest";
            this.buttonAsGuest.Size = new System.Drawing.Size(175, 37);
            this.buttonAsGuest.TabIndex = 3;
            this.buttonAsGuest.Text = "Войти как гость";
            this.buttonAsGuest.UseVisualStyleBackColor = false;
            this.buttonAsGuest.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(461, 172);
            this.Controls.Add(this.buttonAsGuest);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelCheckName);
            this.Controls.Add(this.textBoxCheckName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWelcomeCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCheckName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonAsGuest;
        public System.Windows.Forms.TextBox textBoxCheckName;
    }
}
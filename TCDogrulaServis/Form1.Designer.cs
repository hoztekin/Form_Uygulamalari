namespace TCDogrulaServis
{
    partial class Form1
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
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(31, 44);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(83, 16);
            this.lblTcKimlik.TabIndex = 0;
            this.lblTcKimlik.Text = "TC Kimlik Nu";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(145, 38);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.PasswordChar = '*';
            this.txtTcKimlik.Size = new System.Drawing.Size(150, 22);
            this.txtTcKimlik.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(144, 142);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(151, 22);
            this.txtBirthDate.TabIndex = 3;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(30, 148);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(72, 16);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Doğum Yılı";
            this.lblBirthDate.UseMnemonic = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(145, 107);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(31, 113);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(47, 16);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Soyad";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(33, 184);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(262, 35);
            this.btnDogrula.TabIndex = 4;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 279);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.lblTcKimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TC Doğrula Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnDogrula;
    }
}


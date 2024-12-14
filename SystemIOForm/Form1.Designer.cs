namespace SystemIOForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnGetir = new Button();
            btnKaydet = new Button();
            lstPersonel = new ListBox();
            groupBox2 = new GroupBox();
            txtId = new TextBox();
            label1 = new Label();
            txtEMail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtCountry = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetir);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(lstPersonel);
            groupBox1.Location = new Point(16, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 424);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Listesi";
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(6, 323);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(243, 38);
            btnGetir.TabIndex = 1;
            btnGetir.Text = "Personel Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(9, 367);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(240, 38);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Personel Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstPersonel
            // 
            lstPersonel.FormattingEnabled = true;
            lstPersonel.Location = new Point(9, 29);
            lstPersonel.Name = "lstPersonel";
            lstPersonel.Size = new Size(240, 284);
            lstPersonel.TabIndex = 0;
            lstPersonel.DoubleClick += lstPersonel_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCountry);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtEMail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(291, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 403);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Detay";
            // 
            // txtId
            // 
            txtId.Location = new Point(73, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(185, 27);
            txtId.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 37);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(73, 163);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(185, 27);
            txtEMail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 166);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "EMail";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(73, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 27);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 119);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Soyisim";
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "İsim";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(73, 211);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(185, 27);
            txtCountry.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 214);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 10;
            label5.Text = "Ülke";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem IO İşlemleri";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstPersonel;
        private Button btnGetir;
        private Button btnKaydet;
        private GroupBox groupBox2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEMail;
        private Label label4;
        private TextBox txtId;
        private Label label1;
        private TextBox txtCountry;
        private Label label5;
    }
}

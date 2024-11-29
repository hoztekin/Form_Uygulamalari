namespace BtnUret
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
            this.btnUret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Skor = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblMayin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(475, 12);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(232, 280);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "Buton Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 358);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Skor
            // 
            this.Skor.AutoSize = true;
            this.Skor.Location = new System.Drawing.Point(475, 306);
            this.Skor.Name = "Skor";
            this.Skor.Size = new System.Drawing.Size(35, 16);
            this.Skor.TabIndex = 2;
            this.Skor.Text = "Skor";
            this.Skor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(529, 306);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(0, 16);
            this.lblSkor.TabIndex = 3;
            // 
            // lblMayin
            // 
            this.lblMayin.AutoSize = true;
            this.lblMayin.Location = new System.Drawing.Point(529, 336);
            this.lblMayin.Name = "lblMayin";
            this.lblMayin.Size = new System.Drawing.Size(0, 16);
            this.lblMayin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mayın";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 382);
            this.Controls.Add(this.lblMayin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnUret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Skor;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblMayin;
        private System.Windows.Forms.Label label2;
    }
}

